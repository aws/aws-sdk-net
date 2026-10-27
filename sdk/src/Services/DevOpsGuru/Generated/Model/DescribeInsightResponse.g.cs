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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// This is the response object from the DescribeInsight operation.
    /// </summary>
    public partial class DescribeInsightResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ProactiveInsight. 
        /// <para>
        ///  A <c>ProactiveInsight</c> object that represents the requested insight. 
        /// </para>
        /// </summary>
        public ProactiveInsight ProactiveInsight { get; set; }

        /// <summary>
        /// Checks to see if the ProactiveInsight property is set.
        /// </summary>
        internal bool IsSetProactiveInsight() => this.ProactiveInsight != null;

        /// <summary>
        /// Gets and sets the property ReactiveInsight. 
        /// <para>
        ///  A <c>ReactiveInsight</c> object that represents the requested insight. 
        /// </para>
        /// </summary>
        public ReactiveInsight ReactiveInsight { get; set; }

        /// <summary>
        /// Checks to see if the ReactiveInsight property is set.
        /// </summary>
        internal bool IsSetReactiveInsight() => this.ReactiveInsight != null;
    }
}
