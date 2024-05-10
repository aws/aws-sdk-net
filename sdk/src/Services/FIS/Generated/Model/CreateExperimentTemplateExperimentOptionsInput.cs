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
    /// Specifies experiment options for an experiment template.
    /// </summary>
    public partial class CreateExperimentTemplateExperimentOptionsInput
    {
        private AccountTargeting _accountTargeting;
        private EmptyTargetResolutionMode _emptyTargetResolutionMode;

        /// <summary>
        /// Gets and sets the property AccountTargeting. 
        /// <para>
        /// Specifies the account targeting setting for experiment options.
        /// </para>
        /// </summary>
        public AccountTargeting AccountTargeting
        {
            get { return this._accountTargeting; }
            set { this._accountTargeting = value; }
        }

        // Check to see if AccountTargeting property is set
        internal bool IsSetAccountTargeting()
        {
            return this._accountTargeting != null;
        }

        /// <summary>
        /// Gets and sets the property EmptyTargetResolutionMode. 
        /// <para>
        /// Specifies the empty target resolution mode for experiment options.
        /// </para>
        /// </summary>
        public EmptyTargetResolutionMode EmptyTargetResolutionMode
        {
            get { return this._emptyTargetResolutionMode; }
            set { this._emptyTargetResolutionMode = value; }
        }

        // Check to see if EmptyTargetResolutionMode property is set
        internal bool IsSetEmptyTargetResolutionMode()
        {
            return this._emptyTargetResolutionMode != null;
        }

    }
}