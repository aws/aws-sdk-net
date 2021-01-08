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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Container for the parameters to the StartProjectSession operation.
    /// Creates an interactive session, enabling you to manipulate an AWS Glue DataBrew project.
    /// </summary>
    public partial class StartProjectSessionRequest : AmazonGlueDataBrewRequest
    {
        private bool? _assumeControl;
        private string _name;

        /// <summary>
        /// Gets and sets the property AssumeControl. 
        /// <para>
        /// A value that, if true, enables you to take control of a session, even if a different
        /// client is currently accessing the project.
        /// </para>
        /// </summary>
        public bool AssumeControl
        {
            get { return this._assumeControl.GetValueOrDefault(); }
            set { this._assumeControl = value; }
        }

        // Check to see if AssumeControl property is set
        internal bool IsSetAssumeControl()
        {
            return this._assumeControl.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the project to act upon.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}