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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRestoreImageTask operation.
    /// Starts a task that restores an AMI from an Amazon S3 object that was previously created
    /// by using <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateStoreImageTask.html">CreateStoreImageTask</a>.
    /// 
    ///  
    /// <para>
    /// To use this API, you must have the required permissions. For more information, see
    /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ami-store-restore.html#ami-s3-permissions">Permissions
    /// for storing and restoring AMIs using Amazon S3</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ami-store-restore.html">Store
    /// and restore an AMI using Amazon S3</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateRestoreImageTaskRequest : AmazonEC2Request
    {
        private string _bucket;
        private string _name;
        private string _objectKey;
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The name of the Amazon S3 bucket that contains the stored AMI object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Bucket
        {
            get { return this._bucket; }
            set { this._bucket = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this._bucket != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the restored AMI. The name must be unique for AMIs in the Region for
        /// this account. If you do not provide a name, the new AMI gets the same name as the
        /// original AMI.
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
        /// Gets and sets the property ObjectKey. 
        /// <para>
        /// The name of the stored AMI object in the bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ObjectKey
        {
            get { return this._objectKey; }
            set { this._objectKey = value; }
        }

        // Check to see if ObjectKey property is set
        internal bool IsSetObjectKey()
        {
            return this._objectKey != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the AMI and snapshots on restoration. You can tag the AMI, the
        /// snapshots, or both.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To tag the AMI, the value for <code>ResourceType</code> must be <code>image</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To tag the snapshots, the value for <code>ResourceType</code> must be <code>snapshot</code>.
        /// The same tag is applied to all of the snapshots that are created.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && this._tagSpecifications.Count > 0; 
        }

    }
}