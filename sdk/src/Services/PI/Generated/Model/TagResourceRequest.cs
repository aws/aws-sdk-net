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
 * Do not modify this file. This file is generated from the pi-2018-02-27.normal.json service model.
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
namespace Amazon.PI.Model
{
    /// <summary>
    /// Container for the parameters to the TagResource operation.
    /// Adds metadata tags to the Amazon RDS Performance Insights resource.
    /// </summary>
    public partial class TagResourceRequest : AmazonPIRequest
    {
        private string _resourceARN;
        private ServiceType _serviceType;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ResourceARN. 
        /// <para>
        /// The Amazon RDS Performance Insights resource that the tags are added to. This value
        /// is an Amazon Resource Name (ARN). For information about creating an ARN, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Tagging.ARN.html#USER_Tagging.ARN.Constructing">
        /// Constructing an RDS Amazon Resource Name (ARN)</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string ResourceARN
        {
            get { return this._resourceARN; }
            set { this._resourceARN = value; }
        }

        // Check to see if ResourceARN property is set
        internal bool IsSetResourceARN()
        {
            return this._resourceARN != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceType. 
        /// <para>
        /// The Amazon Web Services service for which Performance Insights returns metrics. Valid
        /// value is <c>RDS</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ServiceType ServiceType
        {
            get { return this._serviceType; }
            set { this._serviceType = value; }
        }

        // Check to see if ServiceType property is set
        internal bool IsSetServiceType()
        {
            return this._serviceType != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata assigned to an Amazon RDS resource consisting of a key-value pair.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}