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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
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
namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Contains the results of validation tests performed against a specific domain controller
    /// during a directory assessment.
    /// </summary>
    public partial class AssessmentReport
    {
        private string _domainControllerIp;
        private List<AssessmentValidation> _validations = AWSConfigs.InitializeCollections ? new List<AssessmentValidation>() : null;

        /// <summary>
        /// Gets and sets the property DomainControllerIp. 
        /// <para>
        /// The IP address of the domain controller that was tested during the assessment.
        /// </para>
        /// </summary>
        public string DomainControllerIp
        {
            get { return this._domainControllerIp; }
            set { this._domainControllerIp = value; }
        }

        // Check to see if DomainControllerIp property is set
        internal bool IsSetDomainControllerIp()
        {
            return this._domainControllerIp != null;
        }

        /// <summary>
        /// Gets and sets the property Validations. 
        /// <para>
        /// A list of validation results for different test categories performed against this
        /// domain controller.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssessmentValidation> Validations
        {
            get { return this._validations; }
            set { this._validations = value; }
        }

        // Check to see if Validations property is set
        internal bool IsSetValidations()
        {
            return this._validations != null && (this._validations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}