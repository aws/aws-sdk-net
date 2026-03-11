using System;
using System.Collections.Generic;
using System.Linq;
using Json.LitJson;

namespace ServiceClientGenerator
{
    #region ExceptionShape

    /// <summary>
    /// The model that represents exceptions for the service
    /// </summary>
    public class ExceptionShape : Shape
    {
        /// <summary>
        /// Creates a model that represents an exception in the service processed in the response
        /// </summary>
        /// <param name="data">The json data that contains information about the exception found in the model</param>
        /// <param name="name">The name of the exception</param>
        /// <param name="documentation">The documentation for the exception found in the service model json</param>
        /// <param name="structure">The shape that represents the exception</param>
        public ExceptionShape(ServiceModel model, string name, JsonData data) : base(model, name, data)
        {
        }

        /// <summary>
        /// Returns the name of the exception with the word Exception appended to the end, removes the word fault from the end if it's there
        /// </summary>
        public override string Name
        {
            get
            {
                string normalizedName;
                if (base.Name.EndsWith("Exception"))
                {
                    normalizedName = base.Name;
                }
                else if (base.Name.EndsWith("Fault"))
                {
                    string trimmedName = base.Name.Substring(0, base.Name.Length - 5);
                    normalizedName = $"{trimmedName}Exception";
                }
                else
                {
                    normalizedName = $"{base.Name}Exception";
                }
                return normalizedName;
            }
        }

        /// <summary>
        /// Members of the shape, defined by another shape.
        /// This overrider removes Message member becuase it's passed to System.Exception directly
        /// </summary>
        public override IList<Member> Members
        {
            get
            {
                return base.Members
                    .Where(member => !member.PropertyName.Equals("Message"))
                    .ToList();
            }
        }

        /// <summary>
        /// The error code for the exception, returns the name if one is not specified in the json model.
        /// We first check in any referenced structure, then fall back to the exception shape to discover
        /// the code.
        /// </summary>
        public string Code
        {
            get
            {
                if (HasErrorCode)
                {
                    return ErrorCode;
                }

                var code = data[ErrorKey]?[ErrorCodeKey]?.ToString();

                return code ?? base.Name;
            }
        }

        /// <summary>
        /// Returns the original shape name of the exception specified in the json model.
        /// This is used to find the exception type for CBOR as the exception response contains
        /// the Shape ID rather than the error code.
        /// https://smithy.io/2.0/additional-specs/protocols/smithy-rpc-v2.html#operation-error-serialization
        /// </summary>
        public string ShapeOriginalName
        {
            get
            {
                return base.Name;
            }
        }

        /// <summary>
        /// Determines if the exception is marked retryable
        /// </summary>
        public bool IsRetryable
        {
            get
            {
                return this.data[RetryableKey] != null;
            }
        }

        /// <summary>
        /// Determines if a retryable exception is marked as throttling
        /// </summary>
        public bool Throttling
        {
            get
            {
                var throttling = this.data[RetryableKey]?[ThrottlingKey];
                return (bool)(throttling ?? false);
            }
        }
    }

    #endregion
}
