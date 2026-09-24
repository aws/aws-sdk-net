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

namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAssessmentFramework operation. Updates a
    /// custom framework in Audit Manager.
    /// </summary>
    public partial class UpdateAssessmentFrameworkRequest : AmazonAuditManagerRequest
    {
        /// <summary>
        /// Gets and sets the property ComplianceType. 
        /// <para>
        ///  The compliance type that the new custom framework supports, such as CIS or HIPAA.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 100)]
        public string ComplianceType { get; set; }

        /// <summary>
        /// Checks to see if the ComplianceType property is set.
        /// </summary>
        internal bool IsSetComplianceType() => this.ComplianceType != null;

        /// <summary>
        /// Gets and sets the property ControlSets. 
        /// <para>
        ///  The control sets that are associated with the framework. 
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>Controls</c> object returns a partial response when called through Framework
        /// APIs. For a complete <c>Controls</c> object, use <c>GetControl</c>.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public List<UpdateAssessmentFrameworkControlSet> ControlSets { get; set; } = AWSConfigs.InitializeCollections ? new List<UpdateAssessmentFrameworkControlSet>() : null;

        /// <summary>
        /// Checks to see if the ControlSets property is set.
        /// </summary>
        internal bool IsSetControlSets() => this.ControlSets != null && (this.ControlSets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description of the updated framework. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FrameworkId. 
        /// <para>
        ///  The unique identifier for the framework. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string FrameworkId { get; set; }

        /// <summary>
        /// Checks to see if the FrameworkId property is set.
        /// </summary>
        internal bool IsSetFrameworkId() => this.FrameworkId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the framework to be updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 300)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
