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
    /// Container for the parameters to the UpdateReviewTemplateLensReview operation.
    /// Update a lens review associated with a review template.
    /// </summary>
    public partial class UpdateReviewTemplateLensReviewRequest : AmazonWellArchitectedRequest
    {
        private string _lensAlias;
        private string _lensNotes;
        private Dictionary<string, string> _pillarNotes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _templateArn;

        /// <summary>
        /// Gets and sets the property LensAlias.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string LensAlias
        {
            get { return this._lensAlias; }
            set { this._lensAlias = value; }
        }

        // Check to see if LensAlias property is set
        internal bool IsSetLensAlias()
        {
            return this._lensAlias != null;
        }

        /// <summary>
        /// Gets and sets the property LensNotes.
        /// </summary>
        [AWSProperty(Max=2084)]
        public string LensNotes
        {
            get { return this._lensNotes; }
            set { this._lensNotes = value; }
        }

        // Check to see if LensNotes property is set
        internal bool IsSetLensNotes()
        {
            return this._lensNotes != null;
        }

        /// <summary>
        /// Gets and sets the property PillarNotes.
        /// </summary>
        public Dictionary<string, string> PillarNotes
        {
            get { return this._pillarNotes; }
            set { this._pillarNotes = value; }
        }

        // Check to see if PillarNotes property is set
        internal bool IsSetPillarNotes()
        {
            return this._pillarNotes != null && (this._pillarNotes.Count > 0 || !AWSConfigs.InitializeCollections); 
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

    }
}