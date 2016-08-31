using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon.Extensions.NETCore.Setup
{
    /// <summary>
    /// Exception for errors loading AWS options from IConfiguration object.
    /// </summary>
    public class ConfigurationException : Exception
    {
        /// <summary>
        /// Construct instance of ConfigurationException
        /// </summary>
        /// <param name="message">The error message.</param>
        public ConfigurationException(string message) : base(message) { }

        /// <summary>
        /// Construct instance of ConfigurationException
        /// </summary>
        /// <param name="message">The error message.</param>
        /// <param name="exception">Original exception.</param>
        public ConfigurationException(string message, Exception exception) : base(message, exception) { }

        /// <summary>
        /// The property that has an invalid value.
        /// </summary>
        public string PropertyName { get; set; }

        /// <summary>
        /// The value that was configured for the PropertyName.
        /// </summary>
        public string PropertyValue { get; set; }
    }
}
