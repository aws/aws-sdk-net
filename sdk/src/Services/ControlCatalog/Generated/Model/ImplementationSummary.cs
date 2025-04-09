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
 * Do not modify this file. This file is generated from the controlcatalog-2018-05-10.normal.json service model.
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
namespace Amazon.ControlCatalog.Model
{
    /// <summary>
    /// A summary of how the control is implemented, including the Amazon Web Services service
    /// that enforces the control and its service-specific identifier. For example, the value
    /// of this field could indicate that the control is implemented as an Amazon Web Services
    /// Config Rule or an Amazon Web Services Security Hub control.
    /// </summary>
    public partial class ImplementationSummary
    {
        private string _identifier;
        private string _type;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The identifier originally assigned by the Amazon Web Services service that implements
        /// the control. For example, <c>CODEPIPELINE_DEPLOYMENT_COUNT_CHECK</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// A string that represents the Amazon Web Services service that implements this control.
        /// For example, a value of <c>AWS::Config::ConfigRule</c> indicates that the control
        /// is implemented by Amazon Web Services Config, and <c>AWS::SecurityHub::SecurityControl</c>
        /// indicates implementation by Amazon Web Services Security Hub.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=7, Max=2048)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}