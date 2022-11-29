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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSensitivityInspectionTemplate operation.
    /// Updates the settings for the sensitivity inspection template for an account.
    /// </summary>
    public partial class UpdateSensitivityInspectionTemplateRequest : AmazonMacie2Request
    {
        private string _description;
        private SensitivityInspectionTemplateExcludes _excludes;
        private string _id;
        private SensitivityInspectionTemplateIncludes _includes;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A custom description of the template.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Excludes.  
        /// <para>
        /// The managed data identifiers to explicitly exclude (not use) when analyzing data.
        /// </para>
        ///  
        /// <para>
        /// To exclude an allow list or custom data identifier that's currently included by the
        /// template, update the values for the SensitivityInspectionTemplateIncludes.allowListIds
        /// and SensitivityInspectionTemplateIncludes.customDataIdentifierIds properties, respectively.
        /// </para>
        /// </summary>
        public SensitivityInspectionTemplateExcludes Excludes
        {
            get { return this._excludes; }
            set { this._excludes = value; }
        }

        // Check to see if Excludes property is set
        internal bool IsSetExcludes()
        {
            return this._excludes != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the Amazon Macie resource that the request applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Includes. 
        /// <para>
        /// The allow lists, custom data identifiers, and managed data identifiers to include
        /// (use) when analyzing data.
        /// </para>
        /// </summary>
        public SensitivityInspectionTemplateIncludes Includes
        {
            get { return this._includes; }
            set { this._includes = value; }
        }

        // Check to see if Includes property is set
        internal bool IsSetIncludes()
        {
            return this._includes != null;
        }

    }
}