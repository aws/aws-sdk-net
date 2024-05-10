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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
        private OverrideButtonConfiguration _android;
        private DefaultButtonConfiguration _defaultConfig;
        private OverrideButtonConfiguration _ios;
        private OverrideButtonConfiguration _web;

        /// <summary>
        /// Gets and sets the property Android. 
        /// <para>
        /// Default button content.
        /// </para>
        /// </summary>
        public OverrideButtonConfiguration Android
        {
            get { return this._android; }
            set { this._android = value; }
        }

        // Check to see if Android property is set
        internal bool IsSetAndroid()
        {
            return this._android != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultConfig. 
        /// <para>
        /// Default button content.
        /// </para>
        /// </summary>
        public DefaultButtonConfiguration DefaultConfig
        {
            get { return this._defaultConfig; }
            set { this._defaultConfig = value; }
        }

        // Check to see if DefaultConfig property is set
        internal bool IsSetDefaultConfig()
        {
            return this._defaultConfig != null;
        }

        /// <summary>
        /// Gets and sets the property IOS. 
        /// <para>
        /// Default button content.
        /// </para>
        /// </summary>
        public OverrideButtonConfiguration IOS
        {
            get { return this._ios; }
            set { this._ios = value; }
        }

        // Check to see if IOS property is set
        internal bool IsSetIOS()
        {
            return this._ios != null;
        }

        /// <summary>
        /// Gets and sets the property Web. 
        /// <para>
        /// Default button content.
        /// </para>
        /// </summary>
        public OverrideButtonConfiguration Web
        {
            get { return this._web; }
            set { this._web = value; }
        }

        // Check to see if Web property is set
        internal bool IsSetWeb()
        {
            return this._web != null;
        }

    }
}