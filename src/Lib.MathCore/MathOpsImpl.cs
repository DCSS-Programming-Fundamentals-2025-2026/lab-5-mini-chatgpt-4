using System;
using Lib.MathCore.Utilities;

namespace Lib.MathCore;

public class MathOpsImpl : IMathOps
{
    public float[] Softmax(ReadOnlySpan<float> logits)
    {
        throw new NotImplementedException();
    }

    public float CrossEntropyLoss(ReadOnlySpan<float> logits, int target)
    {
        throw new NotImplementedException();
    }

    public int ArgMax(ReadOnlySpan<float> scores)
    {
        return ScoreUtilities.ArgMax(scores);
    }

    public int SampleFromProbs(ReadOnlySpan<float> probs, Random rng)
    {
        throw new NotImplementedException();
    }
}