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

/*
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Identifying information about a document attachment, including the file name and a
    /// key-value pair that identifies the location of an attachment to a document.
    /// </summary>
    public partial class AttachmentsSource
    {
        private AttachmentsSourceKey _key;
        private string _name;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The key of a key-value pair that identifies the location of an attachment to a document.
        /// </para>
        /// </summary>
        public AttachmentsSourceKey Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the document attachment file.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The value of a key-value pair that identifies the location of an attachment to a document.
        /// The format for <b>Value</b> depends on the type of key you specify.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For the key <i>SourceUrl</i>, the value is an S3 bucket location. For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>"Values": [ "s3://amzn-s3-demo-bucket/my-prefix" ]</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the key <i>S3FileUrl</i>, the value is a file in an S3 bucket. For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>"Values": [ "s3://amzn-s3-demo-bucket/my-prefix/my-file.py" ]</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the key <i>AttachmentReference</i>, the value is constructed from the name of
        /// another SSM document in your account, a version number of that document, and a file
        /// attached to that document version that you want to reuse. For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>"Values": [ "MyOtherDocument/3/my-other-file.py" ]</c> 
        /// </para>
        ///  
        /// <para>
        /// However, if the SSM document is shared with you from another account, the full SSM
        /// document ARN must be specified instead of the document name only. For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>"Values": [ "arn:aws:ssm:us-east-2:111122223333:document/OtherAccountDocument/3/their-file.py"
        /// ]</c> 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}