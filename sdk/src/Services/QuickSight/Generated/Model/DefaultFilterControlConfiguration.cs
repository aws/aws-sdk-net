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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The default configuration for all dependent controls of the filter.
    /// </summary>
    public partial class DefaultFilterControlConfiguration
    {
        private DefaultFilterControlOptions _controlOptions;
        private string _title;

        /// <summary>
        /// Gets and sets the property ControlOptions. 
        /// <para>
        /// The control option for the <c>DefaultFilterControlConfiguration</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DefaultFilterControlOptions ControlOptions
        {
            get { return this._controlOptions; }
            set { this._controlOptions = value; }
        }

        // Check to see if ControlOptions property is set
        internal bool IsSetControlOptions()
        {
            return this._controlOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the <c>DefaultFilterControlConfiguration</c>. This title is shared by
        /// all controls that are tied to this filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}