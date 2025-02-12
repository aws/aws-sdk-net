/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;

#if BCL
using System.Configuration;
#endif

using Amazon.Util.Internal;

namespace Amazon
{
    /// <summary>
    /// Configuration for the S3 section of AWS configuration.
    /// Changes to some settings may not take effect until a new client is constructed.
    /// 
    /// Example section:
    /// <code>
    /// &lt;configSections&gt;
    ///   &lt;section name="aws" type="Amazon.AWSSection, AWSSDK.Core"/&gt;
    /// &lt;/configSections&gt;
    /// </code>
    /// </summary>
    public static class AWSConfigsS3
    {
        /// <summary>
        /// <para><b>WARNING: Setting DisableMD5Stream to true disables the MD5 data integrity check 
        /// on upload requests.This property has been deprecated in favor of <see cref="DisableDefaultChecksumValidation"/>
        /// Setting the value of DisableMD5Stream will set DisableDefaultChecksumValidation to the same value 
        /// and vice versa. This property was left here for backwards compatibility.</b></para>
        /// <para> 
        /// When true, MD5Stream will not be used in upload requests. This may increase upload 
        /// performance under high CPU loads. The default value is false. Set this value to true to 
        /// disable MD5Stream use in all S3 upload requests or override this value per request by 
        /// setting the DisableMD5Stream property on PutObjectRequest, UploadPartRequest, or 
        /// TransferUtilityUploadRequest.</para>
        /// <para>MD5Stream, SigV4 payload signing, and HTTPS each provide some data integrity 
        /// verification. If DisableMD5Stream is true and DisablePayloadSigning is true, then the 
        /// possibility of data corruption is completely dependant on HTTPS being the only remaining 
        /// source of data integrity verification.</para>
        /// </summary>
        [Obsolete("This property is deprecated in favor of DisableDefaultChecksumValidation.")]
        public static bool DisableMD5Stream
        {
            get { return DisableDefaultChecksumValidation; }
            set { DisableDefaultChecksumValidation = value; }
        }

        /// <summary>
        /// <para><b>WARNING: Setting DisableDefaultChecksumValidation to true disables the default data 
        /// integrity check on upload requests.</b></para>
        /// <para>When true, checksum verification will not be used in upload requests. This may increase upload 
        /// performance under high CPU loads. Setting DisableDefaultChecksumValidation sets the deprecated property
        /// DisableMD5Stream to the same value. The default value is false. Set this value to true to 
        /// disable the default checksum validation used in all S3 upload requests or override this value per
        /// request by setting the DisableDefaultChecksumValidation property on <see cref="S3.Model.PutObjectRequest"/>,
        /// <see cref="S3.Model.UploadPartRequest"/>, or <see cref="S3.Transfer.TransferUtilityUploadRequest"/>.</para>
        /// <para>Checksums, SigV4 payload signing, and HTTPS each provide some data integrity 
        /// verification. If DisableDefaultChecksumValidation is true and DisablePayloadSigning is true, then the 
        /// possibility of data corruption is completely dependent on HTTPS being the only remaining 
        /// source of data integrity verification.</para>
        /// <para>This flag is a rename of the <see cref="DisableMD5Stream"/> property</para>
        /// </summary>
        public static bool DisableDefaultChecksumValidation { get; set; }

        /// <summary>
        /// Escape and unescape S3 metadata for S3 Put/Get object requests.
        /// Escape only escapes non-ascii values in metadata
        /// Any "%" values in metadata could interfere with this option.
        /// Default value is false.
        /// </summary>
        public static bool EnableUnicodeEncodingForObjectMetadata { get; set; } = false;
    }
}
