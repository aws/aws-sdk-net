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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
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
namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateReviewTemplate operation.
    /// Update a review template.
    /// </summary>
    public partial class UpdateReviewTemplateRequest : AmazonWellArchitectedRequest
    {
        private string _description;
        private List<string> _lensesToAssociate = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _lensesToDisassociate = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _notes;
        private string _templateArn;
        private string _templateName;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The review template description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=250)]
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
        /// Gets and sets the property LensesToAssociate. 
        /// <para>
        /// A list of lens aliases or ARNs to apply to the review template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> LensesToAssociate
        {
            get { return this._lensesToAssociate; }
            set { this._lensesToAssociate = value; }
        }

        // Check to see if LensesToAssociate property is set
        internal bool IsSetLensesToAssociate()
        {
            return this._lensesToAssociate != null && (this._lensesToAssociate.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LensesToDisassociate. 
        /// <para>
        /// A list of lens aliases or ARNs to unapply to the review template. The <c>wellarchitected</c>
        /// lens cannot be unapplied.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> LensesToDisassociate
        {
            get { return this._lensesToDisassociate; }
            set { this._lensesToDisassociate = value; }
        }

        // Check to see if LensesToDisassociate property is set
        internal bool IsSetLensesToDisassociate()
        {
            return this._lensesToDisassociate != null && (this._lensesToDisassociate.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Notes.
        /// </summary>
        [AWSProperty(Max=2084)]
        public string Notes
        {
            get { return this._notes; }
            set { this._notes = value; }
        }

        // Check to see if Notes property is set
        internal bool IsSetNotes()
        {
            return this._notes != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateArn. 
        /// <para>
        /// The review template ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=50, Max=250)]
        public string TemplateArn
        {
            get { return this._templateArn; }
            set { this._templateArn = value; }
        }

        // Check to see if TemplateArn property is set
        internal bool IsSetTemplateArn()
        {
            return this._templateArn != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The review template name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=100)]
        public string TemplateName
        {
            get { return this._templateName; }
            set { this._templateName = value; }
        }

        // Check to see if TemplateName property is set
        internal bool IsSetTemplateName()
        {
            return this._templateName != null;
        }

    }
}