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
 * Do not modify this file. This file is generated from the apptest-2022-12-06.normal.json service model.
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
namespace Amazon.AppTest.Model
{
    /// <summary>
    /// Defines the step run summary.
    /// </summary>
    public partial class StepRunSummary
    {
        private CompareActionSummary _compareAction;
        private MainframeActionSummary _mainframeAction;
        private ResourceActionSummary _resourceAction;

        /// <summary>
        /// Gets and sets the property CompareAction. 
        /// <para>
        /// The compare action of the step run summary.
        /// </para>
        /// </summary>
        public CompareActionSummary CompareAction
        {
            get { return this._compareAction; }
            set { this._compareAction = value; }
        }

        // Check to see if CompareAction property is set
        internal bool IsSetCompareAction()
        {
            return this._compareAction != null;
        }

        /// <summary>
        /// Gets and sets the property MainframeAction. 
        /// <para>
        /// The mainframe action of the step run summary.
        /// </para>
        /// </summary>
        public MainframeActionSummary MainframeAction
        {
            get { return this._mainframeAction; }
            set { this._mainframeAction = value; }
        }

        // Check to see if MainframeAction property is set
        internal bool IsSetMainframeAction()
        {
            return this._mainframeAction != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceAction. 
        /// <para>
        /// The resource action of the step run summary.
        /// </para>
        /// </summary>
        public ResourceActionSummary ResourceAction
        {
            get { return this._resourceAction; }
            set { this._resourceAction = value; }
        }

        // Check to see if ResourceAction property is set
        internal bool IsSetResourceAction()
        {
            return this._resourceAction != null;
        }

    }
}