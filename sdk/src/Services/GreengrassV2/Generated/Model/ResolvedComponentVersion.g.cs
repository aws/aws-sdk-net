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

namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Contains information about a component version that is compatible to run on a Greengrass
    /// core device.
    /// </summary>
    public partial class ResolvedComponentVersion
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the component version.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ComponentName. 
        /// <para>
        /// The name of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ComponentName { get; set; }

        /// <summary>
        /// Checks to see if the ComponentName property is set.
        /// </summary>
        internal bool IsSetComponentName() => this.ComponentName != null;

        /// <summary>
        /// Gets and sets the property ComponentVersion. 
        /// <para>
        /// The version of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ComponentVersion { get; set; }

        /// <summary>
        /// Checks to see if the ComponentVersion property is set.
        /// </summary>
        internal bool IsSetComponentVersion() => this.ComponentVersion != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message that communicates details about the vendor guidance state of the component
        /// version. This message communicates why a component version is discontinued or deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property Recipe. 
        /// <para>
        /// The recipe of the component version.
        /// </para>
        /// </summary>
        public MemoryStream Recipe { get; set; }

        /// <summary>
        /// Checks to see if the Recipe property is set.
        /// </summary>
        internal bool IsSetRecipe() => this.Recipe != null;

        /// <summary>
        /// Gets and sets the property VendorGuidance. 
        /// <para>
        /// The vendor guidance state for the component version. This state indicates whether
        /// the component version has any issues that you should consider before you deploy it.
        /// The vendor guidance state can be:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c> – This component version is available and recommended for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISCONTINUED</c> – This component version has been discontinued by its publisher.
        /// You can deploy this component version, but we recommend that you use a different version
        /// of this component.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETED</c> – This component version has been deleted by its publisher, so you
        /// can't deploy it. If you have any existing deployments that specify this component
        /// version, those deployments will fail.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public VendorGuidance VendorGuidance { get; set; }

        /// <summary>
        /// Checks to see if the VendorGuidance property is set.
        /// </summary>
        internal bool IsSetVendorGuidance() => this.VendorGuidance != null;
    }
}
