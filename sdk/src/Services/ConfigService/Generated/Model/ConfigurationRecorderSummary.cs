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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// A summary of a configuration recorder, including the <c>arn</c>, <c>name</c>, <c>servicePrincipal</c>,
    /// and <c>recordingScope</c>.
    /// </summary>
    public partial class ConfigurationRecorderSummary
    {
        private string _arn;
        private string _name;
        private RecordingScope _recordingScope;
        private string _servicePrincipal;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the configuration recorder.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the configuration recorder.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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

        /// <summary>
        /// Gets and sets the property RecordingScope. 
        /// <para>
        /// Indicates whether the <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_ConfigurationItem.html">ConfigurationItems</a>
        /// in scope for the configuration recorder are recorded for free (<c>INTERNAL</c>) or
        /// if you are charged a service fee for recording (<c>PAID</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecordingScope RecordingScope
        {
            get { return this._recordingScope; }
            set { this._recordingScope = value; }
        }

        // Check to see if RecordingScope property is set
        internal bool IsSetRecordingScope()
        {
            return this._recordingScope != null;
        }

        /// <summary>
        /// Gets and sets the property ServicePrincipal. 
        /// <para>
        /// For service-linked configuration recorders, indicates which Amazon Web Services service
        /// the configuration recorder is linked to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ServicePrincipal
        {
            get { return this._servicePrincipal; }
            set { this._servicePrincipal = value; }
        }

        // Check to see if ServicePrincipal property is set
        internal bool IsSetServicePrincipal()
        {
            return this._servicePrincipal != null;
        }

    }
}