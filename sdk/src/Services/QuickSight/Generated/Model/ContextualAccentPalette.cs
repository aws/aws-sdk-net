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
    /// The contextual accent palette.
    /// </summary>
    public partial class ContextualAccentPalette
    {
        private Palette _automation;
        private Palette _connection;
        private Palette _insight;
        private Palette _visualization;

        /// <summary>
        /// Gets and sets the property Automation.
        /// </summary>
        public Palette Automation
        {
            get { return this._automation; }
            set { this._automation = value; }
        }

        // Check to see if Automation property is set
        internal bool IsSetAutomation()
        {
            return this._automation != null;
        }

        /// <summary>
        /// Gets and sets the property Connection.
        /// </summary>
        public Palette Connection
        {
            get { return this._connection; }
            set { this._connection = value; }
        }

        // Check to see if Connection property is set
        internal bool IsSetConnection()
        {
            return this._connection != null;
        }

        /// <summary>
        /// Gets and sets the property Insight.
        /// </summary>
        public Palette Insight
        {
            get { return this._insight; }
            set { this._insight = value; }
        }

        // Check to see if Insight property is set
        internal bool IsSetInsight()
        {
            return this._insight != null;
        }

        /// <summary>
        /// Gets and sets the property Visualization.
        /// </summary>
        public Palette Visualization
        {
            get { return this._visualization; }
            set { this._visualization = value; }
        }

        // Check to see if Visualization property is set
        internal bool IsSetVisualization()
        {
            return this._visualization != null;
        }

    }
}