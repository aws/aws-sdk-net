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
 * Do not modify this file. This file is generated from the oam-2022-06-10.normal.json service model.
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
namespace Amazon.OAM.Model
{
    /// <summary>
    /// This is the response object from the UpdateLink operation.
    /// </summary>
    public partial class UpdateLinkResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _id;
        private string _label;
        private string _labelTemplate;
        private LinkConfiguration _linkConfiguration;
        private List<string> _resourceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _sinkArn;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the link that you have updated.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The random ID string that Amazon Web Services generated as part of the sink ARN.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// The label assigned to this link, with the variables resolved to their actual values.
        /// </para>
        /// </summary>
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }

        // Check to see if Label property is set
        internal bool IsSetLabel()
        {
            return this._label != null;
        }

        /// <summary>
        /// Gets and sets the property LabelTemplate. 
        /// <para>
        /// The exact label template that was specified when the link was created, with the template
        /// variables not resolved.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string LabelTemplate
        {
            get { return this._labelTemplate; }
            set { this._labelTemplate = value; }
        }

        // Check to see if LabelTemplate property is set
        internal bool IsSetLabelTemplate()
        {
            return this._labelTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property LinkConfiguration. 
        /// <para>
        /// This structure includes filters that specify which metric namespaces and which log
        /// groups are shared from the source account to the monitoring account.
        /// </para>
        /// </summary>
        public LinkConfiguration LinkConfiguration
        {
            get { return this._linkConfiguration; }
            set { this._linkConfiguration = value; }
        }

        // Check to see if LinkConfiguration property is set
        internal bool IsSetLinkConfiguration()
        {
            return this._linkConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        /// The resource types now supported by this link.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ResourceTypes
        {
            get { return this._resourceTypes; }
            set { this._resourceTypes = value; }
        }

        // Check to see if ResourceTypes property is set
        internal bool IsSetResourceTypes()
        {
            return this._resourceTypes != null && (this._resourceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SinkArn. 
        /// <para>
        /// The ARN of the sink that is used for this link.
        /// </para>
        /// </summary>
        public string SinkArn
        {
            get { return this._sinkArn; }
            set { this._sinkArn = value; }
        }

        // Check to see if SinkArn property is set
        internal bool IsSetSinkArn()
        {
            return this._sinkArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the link.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
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