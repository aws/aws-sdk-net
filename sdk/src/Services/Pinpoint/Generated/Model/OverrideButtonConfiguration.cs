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
    /// Override button configuration.
    /// </summary>
    public partial class OverrideButtonConfiguration
    {
        private ButtonAction _buttonAction;
        private string _link;

        /// <summary>
        /// Gets and sets the property ButtonAction. 
        /// <para>
        /// Action triggered by the button.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ButtonAction ButtonAction
        {
            get { return this._buttonAction; }
            set { this._buttonAction = value; }
        }

        // Check to see if ButtonAction property is set
        internal bool IsSetButtonAction()
        {
            return this._buttonAction != null;
        }

        /// <summary>
        /// Gets and sets the property Link. 
        /// <para>
        /// Button destination.
        /// </para>
        /// </summary>
        public string Link
        {
            get { return this._link; }
            set { this._link = value; }
        }

        // Check to see if Link property is set
        internal bool IsSetLink()
        {
            return this._link != null;
        }

    }
}