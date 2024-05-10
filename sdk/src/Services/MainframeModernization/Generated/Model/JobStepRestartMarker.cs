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
 * Do not modify this file. This file is generated from the m2-2021-04-28.normal.json service model.
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
namespace Amazon.MainframeModernization.Model
{
    /// <summary>
    /// Provides restart step information for the most recent restart operation.
    /// </summary>
    public partial class JobStepRestartMarker
    {
        private string _fromProcStep;
        private string _fromStep;
        private string _toProcStep;
        private string _toStep;

        /// <summary>
        /// Gets and sets the property FromProcStep. 
        /// <para>
        /// The procedure step name that a job was restarted from.
        /// </para>
        /// </summary>
        public string FromProcStep
        {
            get { return this._fromProcStep; }
            set { this._fromProcStep = value; }
        }

        // Check to see if FromProcStep property is set
        internal bool IsSetFromProcStep()
        {
            return this._fromProcStep != null;
        }

        /// <summary>
        /// Gets and sets the property FromStep. 
        /// <para>
        /// The step name that a batch job restart was from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FromStep
        {
            get { return this._fromStep; }
            set { this._fromStep = value; }
        }

        // Check to see if FromStep property is set
        internal bool IsSetFromStep()
        {
            return this._fromStep != null;
        }

        /// <summary>
        /// Gets and sets the property ToProcStep. 
        /// <para>
        /// The procedure step name that a batch job was restarted to.
        /// </para>
        /// </summary>
        public string ToProcStep
        {
            get { return this._toProcStep; }
            set { this._toProcStep = value; }
        }

        // Check to see if ToProcStep property is set
        internal bool IsSetToProcStep()
        {
            return this._toProcStep != null;
        }

        /// <summary>
        /// Gets and sets the property ToStep. 
        /// <para>
        /// The step name that a job was restarted to.
        /// </para>
        /// </summary>
        public string ToStep
        {
            get { return this._toStep; }
            set { this._toStep = value; }
        }

        // Check to see if ToStep property is set
        internal bool IsSetToStep()
        {
            return this._toStep != null;
        }

    }
}