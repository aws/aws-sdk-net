/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */
using System;
using System.Collections.Generic;
using System.Reflection;

using Amazon.Runtime;
using Amazon.Util;

namespace Amazon.S3
{
    
    /// <summary>
    /// An enumeration of all Metadata directives that
    /// can be used for the CopyObject operation.
    /// </summary>
    public enum S3MetadataDirective
    {
        /// <summary>
        /// Specifies that the metadata is copied from the source object.
        /// </summary>
        COPY,

        /// <summary>
        /// Specifies that the metadata is replaced with metadata provided in the request.
        /// All original metadata is replaced by the metadata you specify.
        /// </summary>
        REPLACE
    }

    /// <summary>
    /// An enumeration of all protocols that the pre-signed
    /// URL can be created against.
    /// </summary>
    public enum Protocol
    {
        /// <summary>
        /// https protocol will be used in the pre-signed URL.
        /// </summary>
        HTTPS,
        /// <summary>
        /// http protocol will be used in the pre-signed URL.
        /// </summary>
        HTTP
    }

    /// <summary>
    /// An enumeration of supported HTTP verbs
    /// </summary>
    public enum HttpVerb
    {
        /// <summary>
        /// The GET HTTP verb.
        /// </summary>
        GET,
        /// <summary>
        /// The HEAD HTTP verb.
        /// </summary>
        HEAD,
        /// <summary>
        /// The PUT HTTP verb.
        /// </summary>
        PUT,
        /// <summary>
        /// The DELETE HTTP verb.
        /// </summary>
        DELETE
    }

    /// <summary>
    /// A list of all server-side encryption methods.
    /// </summary>
    public class ServerSideEncryptionCustomerMethod : ConstantClass
    {
        /// <summary>
        /// No server side encryption to be used.
        /// </summary>
        public static readonly ServerSideEncryptionCustomerMethod None = new ServerSideEncryptionCustomerMethod("");

        /// <summary>
        /// Use AES 256 server side encryption.
        /// </summary>
        public static readonly ServerSideEncryptionCustomerMethod AES256 = new ServerSideEncryptionCustomerMethod("AES256");

        /// <summary>
        /// Constructs an instance of ServerSideEncryptionCustomerMethod.
        /// </summary>
        /// <param name="value"></param>
        public ServerSideEncryptionCustomerMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ServerSideEncryptionCustomerMethod FindValue(string value)
        {
            return FindValue<ServerSideEncryptionCustomerMethod>(value);
        }

        /// <summary>
        /// Converts string to ServerSideEncryptionCustomerMethod.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static implicit operator ServerSideEncryptionCustomerMethod(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// A list of all ACL permissions. For more information, refer to
    /// <see href="http://docs.amazonwebservices.com/AmazonS3/latest/S3_ACLs.html#S3_ACLs_Permissions"/>.
    /// </summary>
    public partial class S3Permission
    {
        /// <summary>
        /// Gives permission to restore an object that is currently stored in Amazon Glacier
        /// for archival storage.
        /// </summary>
        public static readonly S3Permission RESTORE_OBJECT = new S3Permission("RESTORE");
    }
    
    /// <summary>
    /// A list of all possible S3 Bucket region possibilities. For
    /// more information, refer to 
    /// <see href="http://docs.amazonwebservices.com/AmazonS3/latest/BucketConfiguration.html#LocationSelection"/>.
    /// </summary>
    public partial class S3Region : ConstantClass
    {
        /// <summary>
        /// Construct instance of S3Region. It is not intended for this constructor to be called. Instead users should call the FindValue.
        /// </summary>
        /// <param name="value"></param>
        public S3Region(string value)
            : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static S3Region FindValue(string value)
        {
            if (value == null)
                return S3Region.USEast1;

            return FindValue<S3Region>(value);
        }

        /// <summary>
        /// Converts the string to the S3Region class
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static implicit operator S3Region(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// The bucket event for which to send notifications.
    /// </summary>
    public partial class EventType : ConstantClass
    {

        /// <summary>
        /// Compares if the ConstantClass instances are equals.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(ConstantClass obj)
        {
            if (obj == null)
            {
                return false;
            }

            return this.Equals(obj.Value);
        }

        /// <summary>
        /// Compares if the ConstantClass instances are equals. This is ovewritten to handle the 
        /// discrepancy with S3 events coming from Lambda that don't have the prefix "s3:".
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        protected override bool Equals(string value)
        {
            if (value == null)
            {
                return false;
            }

            var thisValue = this.Value;
            if (!thisValue.StartsWith("s3:", StringComparison.OrdinalIgnoreCase))
                thisValue = "s3:" + thisValue;

            if (!value.StartsWith("s3:", StringComparison.OrdinalIgnoreCase))
                value = "s3:" + value;


            return StringComparer.OrdinalIgnoreCase.Equals(thisValue, value);
        }
    }

    /// <summary>
    /// The configuration state for journal tables.
    /// </summary>
    [Obsolete("JournalConfigurationState is deprecated and will be removed in a future version.")]
    public sealed class JournalConfigurationState : ConstantClass
    {
        /// <summary>
        /// Journal configuration is enabled.
        /// </summary>
        public static readonly JournalConfigurationState Enabled = new JournalConfigurationState("ENABLED");

        /// <summary>
        /// Journal configuration is disabled.
        /// </summary>
        public static readonly JournalConfigurationState Disabled = new JournalConfigurationState("DISABLED");

        /// <summary>
        /// Construct instance of JournalConfigurationState.
        /// </summary>
        /// <param name="value"></param>
        public JournalConfigurationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JournalConfigurationState FindValue(string value)
        {
            return FindValue<JournalConfigurationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JournalConfigurationState(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// The constants for the known event names used by S3 notification. S3 might add new
    /// events before the SDK is updated. In which case the names listed in the S3 documentation
    /// will work as well as these constants.
    /// </summary>
    [Obsolete("NotificationEvents is deprecated and will be removed in a future version. Use the EventType enumeration values instead.")]
    public sealed class NotificationEvents
    {
        /// <summary>
        /// An event that says an object has been lost in the reduced redundancy storage.
        /// </summary>
        public static readonly string ReducedRedundancyLostObject = "s3:ReducedRedundancyLostObject";

        private NotificationEvents()
        {
        }
    }
}
