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
    /// Container for the parameters to the GetControl operation.
    /// Returns details about a specific control, most notably a list of Amazon Web Services
    /// Regions where this control is supported. Input a value for the <i>ControlArn</i> parameter,
    /// in ARN form. <c>GetControl</c> accepts <i>controltower</i> or <i>controlcatalog</i>
    /// control ARNs as input. Returns a <i>controlcatalog</i> ARN format.
    /// 
    ///  
    /// <para>
    /// In the API response, controls that have the value <c>GLOBAL</c> in the <c>Scope</c>
    /// field do not show the <c>DeployableRegions</c> field, because it does not apply. Controls
    /// that have the value <c>REGIONAL</c> in the <c>Scope</c> field return a value for the
    /// <c>DeployableRegions</c> field, as shown in the example.
    /// </para>
    /// </summary>
    public partial class GetControlRequest : AmazonControlCatalogRequest
    {
        private string _controlArn;

        /// <summary>
        /// Gets and sets the property ControlArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the control. It has one of the following formats:
        /// </para>
        ///  
        /// <para>
        ///  <i>Global format</i> 
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:{PARTITION}:controlcatalog:::control/{CONTROL_CATALOG_OPAQUE_ID}</c> 
        /// </para>
        ///  
        /// <para>
        ///  <i>Or Regional format</i> 
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:{PARTITION}:controltower:{REGION}::control/{CONTROL_TOWER_OPAQUE_ID}</c> 
        /// </para>
        ///  
        /// <para>
        /// Here is a more general pattern that covers Amazon Web Services Control Tower and Control
        /// Catalog ARNs:
        /// </para>
        ///  
        /// <para>
        ///  <c>^arn:(aws(?:[-a-z]*)?):(controlcatalog|controltower):[a-zA-Z0-9-]*::control/[0-9a-zA-Z_\\-]+$</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=34, Max=2048)]
        public string ControlArn
        {
            get { return this._controlArn; }
            set { this._controlArn = value; }
        }

        // Check to see if ControlArn property is set
        internal bool IsSetControlArn()
        {
            return this._controlArn != null;
        }

    }
}