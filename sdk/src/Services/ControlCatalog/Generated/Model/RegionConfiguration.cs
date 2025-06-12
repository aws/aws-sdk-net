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
 * Do not modify this file. This file is generated from the controlcatalog-2018-05-10.normal.json service model.
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
namespace Amazon.ControlCatalog.Model
{
    /// <summary>
    /// Returns information about the control, including the scope of the control, if enabled,
    /// and the Regions in which the control is available for deployment. For more information
    /// about scope, see <a href="https://docs.aws.amazon.com/whitepapers/latest/aws-fault-isolation-boundaries/global-services.html">Global
    /// services</a>.
    /// 
    ///  
    /// <para>
    /// If you are applying controls through an Amazon Web Services Control Tower landing
    /// zone environment, remember that the values returned in the <c>RegionConfiguration</c>
    /// API operation are not related to the governed Regions in your landing zone. For example,
    /// if you are governing Regions <c>A</c>,<c>B</c>,and <c>C</c> while the control is available
    /// in Regions <c>A</c>, <c>B</c>, C<c>,</c> and <c>D</c>, you'd see a response with <c>DeployableRegions</c>
    /// of <c>A</c>, <c>B</c>, <c>C</c>, and <c>D</c> for a control with <c>REGIONAL</c> scope,
    /// even though you may not intend to deploy the control in Region <c>D</c>, because you
    /// do not govern it through your landing zone.
    /// </para>
    /// </summary>
    public partial class RegionConfiguration
    {
        private List<string> _deployableRegions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ControlScope _scope;

        /// <summary>
        /// Gets and sets the property DeployableRegions. 
        /// <para>
        /// Regions in which the control is available to be deployed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DeployableRegions
        {
            get { return this._deployableRegions; }
            set { this._deployableRegions = value; }
        }

        // Check to see if DeployableRegions property is set
        internal bool IsSetDeployableRegions()
        {
            return this._deployableRegions != null && (this._deployableRegions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The coverage of the control, if deployed. Scope is an enumerated type, with value
        /// <c>Regional</c>, or <c>Global</c>. A control with Global scope is effective in all
        /// Amazon Web Services Regions, regardless of the Region from which it is enabled, or
        /// to which it is deployed. A control implemented by an SCP is usually Global in scope.
        /// A control with Regional scope has operations that are restricted specifically to the
        /// Region from which it is enabled and to which it is deployed. Controls implemented
        /// by Config rules and CloudFormation hooks usually are Regional in scope. Security Hub
        /// controls usually are Regional in scope.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ControlScope Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

    }
}