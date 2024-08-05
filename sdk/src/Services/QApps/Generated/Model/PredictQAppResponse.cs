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
 * Do not modify this file. This file is generated from the qapps-2023-11-27.normal.json service model.
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
namespace Amazon.QApps.Model
{
    /// <summary>
    /// This is the response object from the PredictQApp operation.
    /// </summary>
    public partial class PredictQAppResponse : AmazonWebServiceResponse
    {
        private PredictAppDefinition _app;
        private string _problemStatement;

        /// <summary>
        /// Gets and sets the property App. 
        /// <para>
        /// The generated Q App definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PredictAppDefinition App
        {
            get { return this._app; }
            set { this._app = value; }
        }

        // Check to see if App property is set
        internal bool IsSetApp()
        {
            return this._app != null;
        }

        /// <summary>
        /// Gets and sets the property ProblemStatement. 
        /// <para>
        /// The problem statement extracted from the input conversation, if provided.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProblemStatement
        {
            get { return this._problemStatement; }
            set { this._problemStatement = value; }
        }

        // Check to see if ProblemStatement property is set
        internal bool IsSetProblemStatement()
        {
            return this._problemStatement != null;
        }

    }
}