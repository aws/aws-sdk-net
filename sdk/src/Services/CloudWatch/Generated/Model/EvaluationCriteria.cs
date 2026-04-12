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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
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
namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// The evaluation criteria for an alarm. This is a union type that currently supports
    /// <c>PromQLCriteria</c>.
    /// </summary>
    public partial class EvaluationCriteria
    {
        private AlarmPromQLCriteria _promQLCriteria;

        /// <summary>
        /// Gets and sets the property PromQLCriteria. 
        /// <para>
        /// The PromQL criteria for the alarm evaluation.
        /// </para>
        /// </summary>
        public AlarmPromQLCriteria PromQLCriteria
        {
            get { return this._promQLCriteria; }
            set { this._promQLCriteria = value; }
        }

        // Check to see if PromQLCriteria property is set
        internal bool IsSetPromQLCriteria()
        {
            return this._promQLCriteria != null;
        }

    }
}