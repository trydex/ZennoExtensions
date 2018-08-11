using ZennoExtensionsNew.Exceptions;
using ZennoLab.InterfacesLibrary.ProjectModel;

namespace ZennoExtensionsNew.Validators
{
    public class LocalVariableValidator
    {
        private readonly ILocalVariable _variable;

        public LocalVariableValidator(ILocalVariable variable)
        {
            _variable = variable;
        }

        public LocalVariableException ValidateException { get; set; }

        //private void ThrowException(string message)
        //{
        //    BadEnd(message);
        //    throw new LocalVariableException(message);
        //}

        //private void ThrowIfNotExists(string name)
        //{
        //    var variable = ZennoPlusClient.ZennoProject.Variables.Keys.FirstOrDefault(x => x == _name);
        //    if (variable == null)
        //        throw new VariableNotFoundException($@"Переменная project.Variables[""{_name}""] не найдена!");
        //}

        //public LocalVariableBaseValidatorBuilder IsNotEmpty(string message)
        //{
        //    if (string.IsNullOrWhiteSpace(_value))
        //        ThrowException(message);
        //    return this;
        //}

        //public LocalVariableBaseValidatorBuilder IsInt32(string message)
        //{
        //    if (!_value.IsInt32())
        //        ThrowException(message);
        //    return this;
        //}

        //public LocalVariableBaseValidatorBuilder IsRangeOfInt32(string message, string separator = "-")
        //{
        //    if (!_value.IsRangeOfInt32(separator))
        //        ThrowException(message);
        //    return this;
        //}

        //public LocalVariableBaseValidatorBuilder IsInt32OrRange(string message, string separator = "-")
        //{
        //    var isNumber = _value.IsInt32();
        //    var isRangeOfNumbers = _value.IsRangeOfInt32(separator);
        //    if (!isNumber && !isRangeOfNumbers)
        //        ThrowException(message);
        //    return this;
        //}

        //public LocalVariableBaseValidatorBuilder IsFileExists(string message)
        //{
        //    if (!_value.IsFileExists())
        //        ThrowException(message);
        //    return this;
        //}

        //public LocalVariableBaseValidatorBuilder IsFileNotEmpty(string message)
        //{
        //    if (_value.IsFileEmpty())
        //        ThrowException(message);
        //    return this;
        //}

        //public LocalVariableBaseValidatorBuilder IsDirectoryExists(string message)
        //{
        //    if (!_value.IsDirectoryExists())
        //        ThrowException(message);
        //    return this;
        //}

        //public LocalVariableBaseValidatorBuilder IsDirectoryNotEmpty(string message)
        //{
        //    if (_value.IsDirectoryEmpty())
        //        ThrowException(message);
        //    return this;
        //}

        //public LocalVariableBaseValidatorBuilder IsDateTime(string message)
        //{
        //    if (!_value.IsDateTime())
        //        ThrowException(message);
        //    return this;
        //}

        //public LocalVariableBaseValidatorBuilder IsRangeOfDateTime(string message, string separator = "-")
        //{
        //    if (!_value.IsRangeOfDateTime(separator))
        //        ThrowException(message);
        //    return this;
        //}

        //public LocalVariableBaseValidatorBuilder IsDateTimeOrRange(string message, string separator = "-")
        //{
        //    var isDateTime = _value.IsDateTime();
        //    var isRangeDateTime = _value.IsRangeOfDateTime(separator);
        //    if (!isDateTime && !isRangeDateTime)
        //        ThrowException(message);
        //    return this;
        //}

    }
}   
