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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for all error elements.
    /// </summary>
#if !NETSTANDARD
    [Serializable]
#endif
    public class DeleteError
    {
        
        private string code;
        private string key;
        private string message;
        private string versionId;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The error key.
        /// </para>
        /// </summary>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The version ID of the error.
        /// </para>
        /// </summary>
        public string VersionId
        {
            get { return this.versionId; }
            set { this.versionId = value; }
        }

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The error code is a string that uniquely identifies an error condition. It is meant
        /// to be read and understood by programs that detect and handle errors by type. 
        /// </para>
        ///  <p class="title"> <b>Amazon S3 error codes</b> 
        /// </para>
        ///  <ul> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> AccessDenied 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> Access Denied
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 403 Forbidden
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> AccountProblem
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> There is a problem with your Amazon Web Services account that
        /// prevents the action from completing successfully. Contact Amazon Web Services Support
        /// for further assistance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 403 Forbidden
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> AllAccessDisabled
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> All access to this Amazon S3 resource has been disabled. Contact
        /// Amazon Web Services Support for further assistance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 403 Forbidden
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> AmbiguousGrantByEmailAddress
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> The email address you provided is associated with more than one
        /// account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> AuthorizationHeaderMalformed
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> The authorization header you provided is invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> N/A
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> BadDigest
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> The Content-MD5 you specified did not match what we received.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> BucketAlreadyExists
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> The requested bucket name is not available. The bucket namespace
        /// is shared by all users of the system. Please select a different name and try again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 409 Conflict
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> BucketAlreadyOwnedByYou
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> The bucket you tried to create already exists, and you own it.
        /// Amazon S3 returns this error in all Amazon Web Services Regions except in the North
        /// Virginia Region. For legacy compatibility, if you re-create an existing bucket that
        /// you already own in the North Virginia Region, Amazon S3 returns 200 OK and resets
        /// the bucket access control lists (ACLs).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Code:</i> 409 Conflict (in all Regions except the North Virginia Region) 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> BucketNotEmpty
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> The bucket you tried to delete is not empty.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 409 Conflict
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> CredentialsNotSupported
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> This request does not support credentials.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> CrossLocationLoggingProhibited
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> Cross-location logging not allowed. Buckets in one geographic
        /// location cannot log information to a bucket in another location.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 403 Forbidden
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> EntityTooSmall
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> Your proposed upload is smaller than the minimum allowed object
        /// size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> EntityTooLarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> Your proposed upload exceeds the maximum allowed object size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> ExpiredToken
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> The provided token has expired.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> IllegalVersioningConfigurationException 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> Indicates that the versioning configuration specified in the
        /// request is invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> IncompleteBody
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> You did not provide the number of bytes specified by the Content-Length
        /// HTTP header
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> IncorrectNumberOfFilesInPostRequest
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> POST requires exactly one file upload per request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> InlineDataTooLarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> Inline data exceeds the maximum allowed size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> InternalError
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> We encountered an internal error. Please try again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 500 Internal Server Error
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Server
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> InvalidAccessKeyId
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> The Amazon Web Services access key ID you provided does not exist
        /// in our records.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 403 Forbidden
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> InvalidAddressingHeader
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> You must specify the Anonymous role.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> N/A
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> InvalidArgument
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> Invalid Argument
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> InvalidBucketName
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> The specified bucket is not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> InvalidBucketState
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> The request is not valid with the current state of the bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 409 Conflict
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> InvalidDigest
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> The Content-MD5 you specified is not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> InvalidEncryptionAlgorithmError
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> The encryption request you specified is not valid. The valid
        /// value is AES256.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> InvalidLocationConstraint
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> The specified location constraint is not valid. For more information
        /// about Regions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingBucket.html#access-bucket-intro">How
        /// to Select a Region for Your Buckets</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> InvalidObjectState
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> The action is not valid for the current state of the object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 403 Forbidden
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> InvalidPart
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> One or more of the specified parts could not be found. The part
        /// might not have been uploaded, or the specified entity tag might not have matched the
        /// part's entity tag.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> InvalidPartOrder
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> The list of parts was not in ascending order. Parts list must
        /// be specified in order by part number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> InvalidPayer
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> All access to this object has been disabled. Please contact Amazon
        /// Web Services Support for further assistance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 403 Forbidden
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> InvalidPolicyDocument
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> The content of the form does not meet the conditions specified
        /// in the policy document.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> InvalidRange
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> The requested range cannot be satisfied.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 416 Requested Range Not Satisfiable
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> InvalidRequest
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> Please use <code>AWS4-HMAC-SHA256</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Code:</i> N/A
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> InvalidRequest
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> SOAP requests must be made over an HTTPS connection.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> InvalidRequest
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> Amazon S3 Transfer Acceleration is not supported for buckets
        /// with non-DNS compliant names.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Code:</i> N/A
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> InvalidRequest
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> Amazon S3 Transfer Acceleration is not supported for buckets
        /// with periods (.) in their names.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Code:</i> N/A
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> InvalidRequest
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> Amazon S3 Transfer Accelerate endpoint only supports virtual
        /// style requests.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Code:</i> N/A
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> InvalidRequest
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> Amazon S3 Transfer Accelerate is not configured on this bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Code:</i> N/A
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> InvalidRequest
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> Amazon S3 Transfer Accelerate is disabled on this bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Code:</i> N/A
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> InvalidRequest
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> Amazon S3 Transfer Acceleration is not supported on this bucket.
        /// Contact Amazon Web Services Support for more information.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Code:</i> N/A
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> InvalidRequest
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> Amazon S3 Transfer Acceleration cannot be enabled on this bucket.
        /// Contact Amazon Web Services Support for more information.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Code:</i> N/A
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> InvalidSecurity
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> The provided security credentials are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 403 Forbidden
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> InvalidSOAPRequest
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> The SOAP request body is invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> InvalidStorageClass
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> The storage class you specified is not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> InvalidTargetBucketForLogging
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> The target bucket for logging does not exist, is not owned by
        /// you, or does not have the appropriate grants for the log-delivery group. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> InvalidToken
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> The provided token is malformed or otherwise invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> InvalidURI
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> Couldn't parse the specified URI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> KeyTooLongError
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> Your key is too long.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> MalformedACLError
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> The XML you provided was not well-formed or did not validate
        /// against our published schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> MalformedPOSTRequest 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> The body of your POST request is not well-formed multipart/form-data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> MalformedXML
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> This happens when the user sends malformed XML (XML that doesn't
        /// conform to the published XSD) for the configuration. The error message is, "The XML
        /// you provided was not well-formed or did not validate against our published schema."
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> MaxMessageLengthExceeded
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> Your request was too big.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> MaxPostPreDataLengthExceededError
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> Your POST request fields preceding the upload file were too large.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> MetadataTooLarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> Your metadata headers exceed the maximum allowed metadata size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> MethodNotAllowed
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> The specified method is not allowed against this resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 405 Method Not Allowed
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> MissingAttachment
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> A SOAP attachment was expected, but none were found.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> N/A
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> MissingContentLength
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> You must provide the Content-Length HTTP header.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 411 Length Required
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> MissingRequestBodyError
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> This happens when the user sends an empty XML document as a request.
        /// The error message is, "Request body is empty." 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> MissingSecurityElement
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> The SOAP 1.1 request is missing a security element.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> MissingSecurityHeader
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> Your request is missing a required header.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> NoLoggingStatusForKey
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> There is no such thing as a logging status subresource for a
        /// key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> NoSuchBucket
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> The specified bucket does not exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 404 Not Found
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> NoSuchBucketPolicy
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> The specified bucket does not have a bucket policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 404 Not Found
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> NoSuchKey
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> The specified key does not exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 404 Not Found
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> NoSuchLifecycleConfiguration
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> The lifecycle configuration does not exist. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 404 Not Found
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> NoSuchUpload
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> The specified multipart upload does not exist. The upload ID
        /// might be invalid, or the multipart upload might have been aborted or completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 404 Not Found
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> NoSuchVersion 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> Indicates that the version ID specified in the request does not
        /// match an existing version.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 404 Not Found
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> NotImplemented
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> A header you provided implies functionality that is not implemented.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 501 Not Implemented
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Server
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> NotSignedUp
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> Your account is not signed up for the Amazon S3 service. You
        /// must sign up before you can use Amazon S3. You can sign up at the following URL: <a
        /// href="http://aws.amazon.com/s3">Amazon S3</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 403 Forbidden
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> OperationAborted
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> A conflicting conditional action is currently in progress against
        /// this resource. Try again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 409 Conflict
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> PermanentRedirect
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> The bucket you are attempting to access must be addressed using
        /// the specified endpoint. Send all future requests to this endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 301 Moved Permanently
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> PreconditionFailed
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> At least one of the preconditions you specified did not hold.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 412 Precondition Failed
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> Redirect
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> Temporary redirect.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 307 Moved Temporarily
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> RestoreAlreadyInProgress
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> Object restore is already in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 409 Conflict
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> RequestIsNotMultiPartContent
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> Bucket POST must be of the enclosure-type multipart/form-data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> RequestTimeout
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> Your socket connection to the server was not read from or written
        /// to within the timeout period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> RequestTimeTooSkewed
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> The difference between the request time and the server's time
        /// is too large.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 403 Forbidden
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> RequestTorrentOfBucketError
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> Requesting the torrent file of a bucket is not permitted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> SignatureDoesNotMatch
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> The request signature we calculated does not match the signature
        /// you provided. Check your Amazon Web Services secret access key and signing method.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/RESTAuthentication.html">REST
        /// Authentication</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/SOAPAuthentication.html">SOAP
        /// Authentication</a> for details.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 403 Forbidden
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> ServiceUnavailable
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> Reduce your request rate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 503 Service Unavailable
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Server
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> SlowDown
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> Reduce your request rate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 503 Slow Down
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Server
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> TemporaryRedirect
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> You are being redirected to the bucket while DNS updates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 307 Moved Temporarily
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> TokenRefreshRequired
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> The provided token must be refreshed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> TooManyBuckets
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> You have attempted to create more buckets than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> UnexpectedContent
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> This request does not support content.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> UnresolvableGrantByEmailAddress
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> The email address you provided does not match any account on
        /// record.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code:</i> UserKeyMustBeSpecified
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Description:</i> The bucket POST must contain the specified field name. If it
        /// is specified, check the order of the fields.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code:</i> 400 Bad Request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix:</i> Client
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        public string Code
        {
            get { return this.code; }
            set { this.code = value; }
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The error message contains a generic description of the error condition in English.
        /// It is intended for a human audience. Simple programs display the message directly
        /// to the end user if they encounter an error condition they don't know how or don't
        /// care to handle. Sophisticated programs with more exhaustive error handling and proper
        /// internationalization are more likely to ignore the error message.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this.message; }
            set { this.message = value; }
        }
    }
}
