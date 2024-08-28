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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the PutDataQualityProfileAnnotation operation.
    /// Annotate all datapoints for a Profile.
    /// </summary>
    public partial class PutDataQualityProfileAnnotationRequest : AmazonGlueRequest
    {
        private InclusionAnnotationValue _inclusionAnnotation;
        private string _profileId;

        /// <summary>
        /// Gets and sets the property InclusionAnnotation. 
        /// <para>
        /// The inclusion annotation value to apply to the profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InclusionAnnotationValue InclusionAnnotation
        {
            get { return this._inclusionAnnotation; }
            set { this._inclusionAnnotation = value; }
        }

        // Check to see if InclusionAnnotation property is set
        internal bool IsSetInclusionAnnotation()
        {
            return this._inclusionAnnotation != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// The ID of the data quality monitoring profile to annotate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ProfileId
        {
            get { return this._profileId; }
            set { this._profileId = value; }
        }

        // Check to see if ProfileId property is set
        internal bool IsSetProfileId()
        {
            return this._profileId != null;
        }

    }
}