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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
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
namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Details for client authentication using SASL.
    /// </summary>
    public partial class Sasl
    {
        private Iam _iam;
        private Scram _scram;

        /// <summary>
        /// Gets and sets the property Iam.             
        /// <para>
        /// Indicates whether IAM access control is enabled.
        /// </para>
        /// </summary>
        public Iam Iam
        {
            get { return this._iam; }
            set { this._iam = value; }
        }

        // Check to see if Iam property is set
        internal bool IsSetIam()
        {
            return this._iam != null;
        }

        /// <summary>
        /// Gets and sets the property Scram.             
        /// <para>
        /// Details for SASL/SCRAM client authentication.
        /// </para>
        /// </summary>
        public Scram Scram
        {
            get { return this._scram; }
            set { this._scram = value; }
        }

        // Check to see if Scram property is set
        internal bool IsSetScram()
        {
            return this._scram != null;
        }

    }
}