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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Ttml Destination Settings
    /// </summary>
    public partial class TtmlDestinationSettings
    {
        private TtmlDestinationStyleControl _styleControl;

        /// <summary>
        /// Gets and sets the property StyleControl. This field is not currently supported and
        /// will not affect the output styling. Leave the default value.
        /// </summary>
        public TtmlDestinationStyleControl StyleControl
        {
            get { return this._styleControl; }
            set { this._styleControl = value; }
        }

        // Check to see if StyleControl property is set
        internal bool IsSetStyleControl()
        {
            return this._styleControl != null;
        }

    }
}