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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
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
namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// Object to store configuration of layouts associated to the template.
    /// </summary>
    public partial class LayoutConfiguration
    {
        private string _defaultLayout;

        /// <summary>
        /// Gets and sets the property DefaultLayout. 
        /// <para>
        ///  Unique identifier of a layout. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public string DefaultLayout
        {
            get { return this._defaultLayout; }
            set { this._defaultLayout = value; }
        }

        // Check to see if DefaultLayout property is set
        internal bool IsSetDefaultLayout()
        {
            return this._defaultLayout != null;
        }

    }
}