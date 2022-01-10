using static Binner.Model.Common.SystemDefaults;

namespace Binner.Model.Common
{
    public class ParentAttribute : Attribute
    {
        DefaultPartTypes Parent { get; }
        public ParentAttribute(DefaultPartTypes parent)
        {
            Parent = parent;
        }
    }
}
