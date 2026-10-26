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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Button Config for an in-app message.
    /// </summary>
    public partial class InAppMessageButton
    {
        /// <summary>
        /// Gets and sets the property Android. 
        /// <para>
        /// Default button content.
        /// </para>
        /// </summary>
        public OverrideButtonConfiguration Android { get; set; }

        /// <summary>
        /// Checks to see if the Android property is set.
        /// </summary>
        internal bool IsSetAndroid() => this.Android != null;

        /// <summary>
        /// Gets and sets the property DefaultConfig. 
        /// <para>
        /// Default button content.
        /// </para>
        /// </summary>
        public DefaultButtonConfiguration DefaultConfig { get; set; }

        /// <summary>
        /// Checks to see if the DefaultConfig property is set.
        /// </summary>
        internal bool IsSetDefaultConfig() => this.DefaultConfig != null;

        /// <summary>
        /// Gets and sets the property IOS. 
        /// <para>
        /// Default button content.
        /// </para>
        /// </summary>
        public OverrideButtonConfiguration IOS { get; set; }

        /// <summary>
        /// Checks to see if the IOS property is set.
        /// </summary>
        internal bool IsSetIOS() => this.IOS != null;

        /// <summary>
        /// Gets and sets the property Web. 
        /// <para>
        /// Default button content.
        /// </para>
        /// </summary>
        public OverrideButtonConfiguration Web { get; set; }

        /// <summary>
        /// Checks to see if the Web property is set.
        /// </summary>
        internal bool IsSetWeb() => this.Web != null;
    }
}
