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
 * Do not modify this file. This file is generated from the fis-2020-12-01.normal.json service model.
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
namespace Amazon.FIS.Model
{
    /// <summary>
    /// Specifies experiment options for running an experiment.
    /// </summary>
    public partial class StartExperimentExperimentOptionsInput
    {
        private ActionsMode _actionsMode;

        /// <summary>
        /// Gets and sets the property ActionsMode. 
        /// <para>
        /// Specifies the actions mode for experiment options.
        /// </para>
        /// </summary>
        public ActionsMode ActionsMode
        {
            get { return this._actionsMode; }
            set { this._actionsMode = value; }
        }

        // Check to see if ActionsMode property is set
        internal bool IsSetActionsMode()
        {
            return this._actionsMode != null;
        }

    }
}