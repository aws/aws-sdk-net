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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
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
        private string _arn;
        private string _componentName;
        private string _componentVersion;
        private string _message;
        private MemoryStream _recipe;
        private VendorGuidance _vendorGuidance;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the component version.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ComponentName. 
        /// <para>
        /// The name of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ComponentName
        {
            get { return this._componentName; }
            set { this._componentName = value; }
        }

        // Check to see if ComponentName property is set
        internal bool IsSetComponentName()
        {
            return this._componentName != null;
        }

        /// <summary>
        /// Gets and sets the property ComponentVersion. 
        /// <para>
        /// The version of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ComponentVersion
        {
            get { return this._componentVersion; }
            set { this._componentVersion = value; }
        }

        // Check to see if ComponentVersion property is set
        internal bool IsSetComponentVersion()
        {
            return this._componentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message that communicates details about the vendor guidance state of the component
        /// version. This message communicates why a component version is discontinued or deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Recipe. 
        /// <para>
        /// The recipe of the component version.
        /// </para>
        /// </summary>
        public MemoryStream Recipe
        {
            get { return this._recipe; }
            set { this._recipe = value; }
        }

        // Check to see if Recipe property is set
        internal bool IsSetRecipe()
        {
            return this._recipe != null;
        }

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
        public VendorGuidance VendorGuidance
        {
            get { return this._vendorGuidance; }
            set { this._vendorGuidance = value; }
        }

        // Check to see if VendorGuidance property is set
        internal bool IsSetVendorGuidance()
        {
            return this._vendorGuidance != null;
        }

    }
}