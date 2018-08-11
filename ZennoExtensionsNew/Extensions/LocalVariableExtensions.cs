using ZennoExtensionsNew.Validators;
using ZennoLab.InterfacesLibrary.ProjectModel;

namespace ZennoExtensionsNew.Extensions
{
    public static class LocalVariableExtensions
    {
        public static LocalVariableValidator GetValidator(this ILocalVariable variable) => new LocalVariableValidator(variable);
    }
}   