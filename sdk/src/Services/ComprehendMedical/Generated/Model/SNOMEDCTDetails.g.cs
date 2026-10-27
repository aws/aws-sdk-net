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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.ComprehendMedical.Model
{
    /// <summary>
    /// The information about the revision of the SNOMED-CT ontology in the response. Specifically,
    /// the details include the SNOMED-CT edition, language, and version date.
    /// </summary>
    public partial class SNOMEDCTDetails
    {
        /// <summary>
        /// Gets and sets the property Edition. 
        /// <para>
        ///  The edition of SNOMED-CT used. The edition used for the InferSNOMEDCT editions is
        /// the US edition. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Edition { get; set; }

        /// <summary>
        /// Checks to see if the Edition property is set.
        /// </summary>
        internal bool IsSetEdition() => this.Edition != null;

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        ///  The language used in the SNOMED-CT ontology. All Amazon Comprehend Medical operations
        /// are US English (en). 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Language { get; set; }

        /// <summary>
        /// Checks to see if the Language property is set.
        /// </summary>
        internal bool IsSetLanguage() => this.Language != null;

        /// <summary>
        /// Gets and sets the property VersionDate. 
        /// <para>
        ///  The version date of the SNOMED-CT ontology used. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string VersionDate { get; set; }

        /// <summary>
        /// Checks to see if the VersionDate property is set.
        /// </summary>
        internal bool IsSetVersionDate() => this.VersionDate != null;
    }
}
