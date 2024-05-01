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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
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
namespace Amazon.Personalize.Model
{
    /// <summary>
    /// The automatic training configuration to use when <c>performAutoTraining</c> is true.
    /// </summary>
    public partial class AutoTrainingConfig
    {
        private string _schedulingExpression;

        /// <summary>
        /// Gets and sets the property SchedulingExpression. 
        /// <para>
        /// Specifies how often to automatically train new solution versions. Specify a rate expression
        /// in rate(<i>value</i> <i>unit</i>) format. For value, specify a number between 1 and
        /// 30. For unit, specify <c>day</c> or <c>days</c>. For example, to automatically create
        /// a new solution version every 5 days, specify <c>rate(5 days)</c>. The default is every
        /// 7 days.
        /// </para>
        ///  
        /// <para>
        /// For more information about auto training, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/customizing-solution-config.html">Creating
        /// and configuring a solution</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=16)]
        public string SchedulingExpression
        {
            get { return this._schedulingExpression; }
            set { this._schedulingExpression = value; }
        }

        // Check to see if SchedulingExpression property is set
        internal bool IsSetSchedulingExpression()
        {
            return this._schedulingExpression != null;
        }

    }
}