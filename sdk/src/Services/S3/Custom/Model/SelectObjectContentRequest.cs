// /*******************************************************************************
//  *  Copyright 2008-2018 Amazon.com, Inc. or its affiliates. All Rights Reserved.
//  *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
//  *  this file except in compliance with the License. A copy of the License is located at
//  *
//  *  http://aws.amazon.com/apache2.0
//  *
//  *  or in the "license" file accompanying this file.
//  *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
//  *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
//  *  specific language governing permissions and limitations under the License.
//  * *****************************************************************************
//  *    __  _    _  ___
//  *   (  )( \/\/ )/ __)
//  *   /__\ \    / \__ \
//  *  (_)(_) \/\/  (___/
//  *
//  *  AWS SDK for .NET
//  *
//  */

using Amazon.Runtime;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Request to filter the contents of an Amazon S3 object based on a simple Structured Query Language (SQL) statement.
    /// <para>
    /// In the request, along with the SQL expression, you must also specify a data serialization format (JSON or CSV) of the object.
    /// Amazon S3 uses this to parse object data into records, and returns only records
    /// that match the specified SQL expression. You must also specify the data serialization format for the response.
    /// </para>
    /// </summary>
    /// <seealso href="https://docs.aws.amazon.com/AmazonS3/latest/API/RESTObjectSELECTContent.html">
    /// S3Select API Documentation
    /// </seealso>
    public class SelectObjectContentRequest : AmazonWebServiceRequest
    {
        /// <summary>
        /// The S3 Bucket.
        /// </summary>
        public string Bucket { get; set; }

        internal bool IsSetBucket() => Bucket != null;

        /// <summary>
        /// The Object Key.
        /// </summary>
        public string Key { get; set; }

        internal bool IsSetKey() => Key != null;

        /// <summary>
        /// The SSE Algorithm used to encrypt the object.
        /// </summary>
        /// <seealso href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ServerSideEncryptionCustomerKeys.html">
        /// Server-Side Encryption (Using Customer-Provided Encryption Keys.
        /// </seealso>
        public ServerSideEncryptionCustomerMethod ServerSideCustomerEncryptionMethod { get; set; }

        internal bool IsSetServerSideCustomerEncryptionMethod() => ServerSideCustomerEncryptionMethod != null;

        /// <summary>
        /// The SSE Customer Key.
        /// </summary>
        /// <seealso href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ServerSideEncryptionCustomerKeys.html">
        /// Server-Side Encryption (Using Customer-Provided Encryption Keys.
        /// </seealso>
        public string ServerSideEncryptionCustomerProvidedKey { get; set; }

        internal bool IsSetServerSideEncryptionCustomerProvidedKey() => ServerSideEncryptionCustomerProvidedKey != null;

        /// <summary>
        /// The SSE Customer Key MD5.
        /// </summary>
        /// <seealso href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ServerSideEncryptionCustomerKeys.html">
        /// Server-Side Encryption (Using Customer-Provided Encryption Keys.
        /// </seealso>
        public string ServerSideEncryptionCustomerProvidedKeyMD5 { get; set; }

        internal bool IsSetServerSideEncryptionCustomerProvidedKeyMD5() =>
            ServerSideEncryptionCustomerProvidedKeyMD5 != null;

        /// <summary>
        /// The expression that is used to query the object.
        /// </summary>
        public string Expression { get; set; }

        internal bool IsSetExpression() => Expression != null;

        /// <summary>
        /// The type of the provided expression (e.g., SQL).
        /// </summary>
        public ExpressionType ExpressionType { get; set; }

        internal bool IsSetExpressionType() => ExpressionType != null;

        /// <summary>
        /// Specifies if periodic request progress information should be enabled.
        /// </summary>
        public bool? RequestProgress { get; set; }

        internal bool IsSetRequestProgress() => RequestProgress != null;
        
        /// <summary>
        /// Describes the format of the data in the object that is being queried.
        /// </summary>
        public InputSerialization InputSerialization { get; set; }

        internal bool IsSetInputSerialization() => InputSerialization != null;

        /// <summary>
        /// Describes the format of the data that you want Amazon S3 to return in response.
        /// </summary>
        public OutputSerialization OutputSerialization { get; set; }

        internal bool IsSetOutputSerialization() => OutputSerialization != null;

        /// <summary>
        /// The byte range of the object to get the records from.
        /// </summary>
        public ScanRange ScanRange { get; set; }

        internal bool IsSetScanRange() => ScanRange != null;
    }
}