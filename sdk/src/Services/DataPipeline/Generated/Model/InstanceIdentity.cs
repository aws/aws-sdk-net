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
 * Do not modify this file. This file is generated from the datapipeline-2012-10-29.normal.json service model.
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
namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// <para>
    /// Identity information for the EC2 instance that is hosting the task runner. You can
    /// get this value by calling a metadata URI from the EC2 instance. For more information,
    /// see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/AESDG-chapter-instancedata.html">Instance
    /// Metadata</a> in the <i>Amazon Elastic Compute Cloud User Guide.</i> Passing in this
    /// value proves that your task runner is running on an EC2 instance, and ensures the
    /// proper AWS Data Pipeline service charges are applied to your pipeline.
    /// 
    /// 
    /// </para>
    /// </summary>
    public partial class InstanceIdentity
    {
        private string _document;
        private string _signature;

        /// <summary>
        /// Gets and sets the property Document. 
        /// <para>
        /// A description of an EC2 instance that is generated when the instance is launched and
        /// exposed to the instance via the instance metadata service in the form of a JSON representation
        /// of an object.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Document
        {
            get { return this._document; }
            set { this._document = value; }
        }

        // Check to see if Document property is set
        internal bool IsSetDocument()
        {
            return this._document != null;
        }

        /// <summary>
        /// Gets and sets the property Signature. 
        /// <para>
        /// A signature which can be used to verify the accuracy and authenticity of the information
        /// provided in the instance identity document.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Signature
        {
            get { return this._signature; }
            set { this._signature = value; }
        }

        // Check to see if Signature property is set
        internal bool IsSetSignature()
        {
            return this._signature != null;
        }

    }
}