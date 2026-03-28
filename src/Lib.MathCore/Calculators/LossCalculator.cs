using System;

namespace Lib.MathCore;

public static class LossCalculator
{
    public static float CrossEntropyLoss(ReadOnlySpan<float> logits, int target)
    {
        if (logits.Length == 0)
            throw new ArgumentException("Logits cannot be empty");

        if (target < 0 || target >= logits.Length)
            throw new ArgumentOutOfRangeException(nameof(target));

        var probs = SoftmaxCalculator.Softmax(logits);

        float p = probs[target];

        if (p <= 0f)
            p = 1e-9f;

        return -MathF.Log(p);
    }
}