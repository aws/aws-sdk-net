using Json.LitJson;
using System;
using System.Collections.Generic;

namespace ServiceClientGenerator
{
    /// <summary>
    /// Algorithms for validating request and response integrity for supported operations.
    /// These are the algorithms supported by the .NET SDK, and the superset of the modeled
    /// response algorithms for a given operation.
    /// </summary>
    public enum ChecksumAlgorithm
    {
        CRC32C,
        CRC32,
        SHA256,
        SHA1
    }

    /// <summary>
    /// Represents the request and response checksum configuration for a given operation, 
    /// read from the "httpChecksum" trait applied at the operation-level in a service model.
    /// </summary>
    public class ChecksumConfiguration
    {
        /// <summary>
        ///  Indicates if checksum MUST be present in the operation's HTTP request
        /// </summary>
        public bool RequestChecksumRequired { get; set; }

        /// <summary>
        /// Represents the member name of the operation input member used to configure the request checksum behavior.
        /// The operation input member MUST target an enum representing the supported checksum algorithms.
        /// </summary>
        public string RequestAlgorithmMember { get; set; }

        /// <summary>
        /// Represents the member name of the operation input member used to opt-in for the best effort validation of the checksums returned
        /// on the response. The operation input member MUST target an enum and the only supported enum value is "ENABLED".
        /// </summary>
        public string RequestValidationModeMember { get; set; }

        /// <summary>
        /// List of checksum algorithms for which clients should perform checksum validation 
        /// if the checksum data value is present in the response headers.
        /// </summary>
        public List<ChecksumAlgorithm> ResponseAlgorithms { get; set; }

        public ChecksumConfiguration(JsonData data)
        {
            if (data[ServiceModel.RequestChecksumRequiredKey] != null)
            {
                if (data[ServiceModel.RequestChecksumRequiredKey].IsBoolean)
                {
                    RequestChecksumRequired = (bool)data[ServiceModel.RequestChecksumRequiredKey];
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"{data[ServiceModel.RequestChecksumRequiredKey]} is not a valid boolean value for {ServiceModel.RequestChecksumRequiredKey}");
                }
            }

            RequestAlgorithmMember = data.SafeGetString(ServiceModel.RequestAlgorithmMemberKey);
            RequestValidationModeMember = data.SafeGetString(ServiceModel.RequestValidationModeMemberKey);
            ResponseAlgorithms = ParseList(data[ServiceModel.ResponseAlgorithmsKey]);
        }

        public static List<ChecksumAlgorithm> ParseList(JsonData jsonData)
        {
            var algorithms = new List<ChecksumAlgorithm>();

            if (jsonData != null && jsonData.IsArray)
            {
                var invalidAlgorithms = new List<string>();

                foreach (JsonData rawAlgorithm in jsonData)
                {
                    if (Enum.TryParse<ChecksumAlgorithm>((string)rawAlgorithm, false, out var parsedAlgorithm))
                    {
                        algorithms.Add(parsedAlgorithm);
                    }
                    else 
                    {
                        invalidAlgorithms.Add(rawAlgorithm.ToString());
                    }
                }

                if (invalidAlgorithms.Count > 0)
                {
                    throw new ArgumentOutOfRangeException($"Found one or more more unsupported values for {nameof(ChecksumAlgorithm)}: {string.Join(",", invalidAlgorithms)}");
                }
            }
            return algorithms;
        }
    }
}
