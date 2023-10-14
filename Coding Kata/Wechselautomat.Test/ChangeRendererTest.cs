using Wechselautomat.Core;
using Wechselautomat.Core.ValueObjects;

namespace Wechselautomat.Test;

[UsesVerify]
public class ChangeRendererTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public async Task Render(Amount amount, IEnumerable<Change> changes)
    {
        var rendering = ChangeRenderer.Render(changes);
        await Verify(rendering).UseParameters(amount);
    }

    public static TheoryData<Amount, Change[]> TestData =>
    new()
    {
        { 0.00m, Array.Empty<Change>() },
        { 15.46m, new Change[]
            {
                new(1, new Coin(.01m)),
                new(1, new Coin(.05m)),
                new(2, new Coin(.20m)),
                new(1, new Note(5)),
                new(1, new Note(10)),
            }
        },
        { 7.46m, new Change[]
            {
                new(1, new Note(5m)),
                new(1, new Coin(2m)),
                new(2, new Coin(.20m)),
                new(1, new Coin(.05m)),
                new(1, new Coin(.01m)),
            }
        },
        { 4.57m, new Change[]
            {
                new(2, new Coin(2m)),
                new(1, new Coin(.50m)),
                new(1, new Coin(.05m)),
                new(1, new Coin(.02m)),
            }
        },
        { 50.00m, new Change[]
            {
                new(1, new Note(50m))
            }
        }
    };
}
