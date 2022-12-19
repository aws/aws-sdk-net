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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateImage operation.
    /// Updates the properties of a SageMaker image. To change the image's tags, use the <a>AddTags</a>
    /// and <a>DeleteTags</a> APIs.
    /// </summary>
    public partial class UpdateImageRequest : AmazonSageMakerRequest
    {
        private List<string> _deleteProperties = new List<string>();
        private string _description;
        private string _displayName;
        private string _imageName;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property DeleteProperties. 
        /// <para>
        /// A list of properties to delete. Only the <code>Description</code> and <code>DisplayName</code>
        /// properties can be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2)]
        public List<string> DeleteProperties
        {
            get { return this._deleteProperties; }
            set { this._deleteProperties = value; }
        }

        // Check to see if DeleteProperties property is set
        internal bool IsSetDeleteProperties()
        {
            return this._deleteProperties != null && this._deleteProperties.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The new description for the image.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The new display name for the image.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property ImageName. 
        /// <para>
        /// The name of the image to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string ImageName
        {
            get { return this._imageName; }
            set { this._imageName = value; }
        }

        // Check to see if ImageName property is set
        internal bool IsSetImageName()
        {
            return this._imageName != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The new ARN for the IAM role that enables Amazon SageMaker to perform tasks on your
        /// behalf.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}