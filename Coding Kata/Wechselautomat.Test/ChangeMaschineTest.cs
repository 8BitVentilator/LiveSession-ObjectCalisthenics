
using Argon;
using Wechselautomat.Core;
using Wechselautomat.Core.ValueObjects;

namespace Wechselautomat;

[UsesVerify]
public class ChangeMaschineTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public async Task Changes(decimal paying, decimal receiving)
    {
        var changes = ChangeMaschine.Changes(new Paying(paying), new Receiving(receiving));
        await Verify(changes).UseParameters(paying, receiving);
    }

    public static TheoryData<decimal, decimal> TestData =>
        new()
        {
            { 34.54m, 50m },
            { 10m, 10m },
            { 50m, 100m },
            { 12.54m, 20m },
            { 15.43m, 20m }
        };
}
