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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
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
namespace Amazon.Backup.Model
{
    /// <summary>
    /// Container for the parameters to the UntagResource operation.
    /// Removes a set of key-value pairs from a recovery point, backup plan, or backup vault
    /// identified by an Amazon Resource Name (ARN)
    /// 
    ///  
    /// <para>
    /// This API is not supported for recovery points for resource types including Aurora,
    /// Amazon DocumentDB. Amazon EBS, Amazon FSx, Neptune, and Amazon RDS.
    /// </para>
    /// </summary>
    public partial class UntagResourceRequest : AmazonBackupRequest
    {
        private string _resourceArn;
        private List<string> _tagKeyList = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// An ARN that uniquely identifies a resource. The format of the ARN depends on the type
        /// of the tagged resource.
        /// </para>
        ///  
        /// <para>
        /// ARNs that do not include <c>backup</c> are incompatible with tagging. <c>TagResource</c>
        /// and <c>UntagResource</c> with invalid ARNs will result in an error. Acceptable ARN
        /// content can include <c>arn:aws:backup:us-east</c>. Invalid ARN content may look like
        /// <c>arn:aws:ec2:us-east</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property TagKeyList. 
        /// <para>
        /// The keys to identify which key-value tags to remove from a resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public List<string> TagKeyList
        {
            get { return this._tagKeyList; }
            set { this._tagKeyList = value; }
        }

        // Check to see if TagKeyList property is set
        internal bool IsSetTagKeyList()
        {
            return this._tagKeyList != null && (this._tagKeyList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}