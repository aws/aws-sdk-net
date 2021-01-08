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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// This is the response object from the DescribeInsight operation.
    /// </summary>
    public partial class DescribeInsightResponse : AmazonWebServiceResponse
    {
        private ProactiveInsight _proactiveInsight;
        private ReactiveInsight _reactiveInsight;

        /// <summary>
        /// Gets and sets the property ProactiveInsight. 
        /// <para>
        ///  An <code>ProactiveInsight</code> object that represents the requested insight. 
        /// </para>
        /// </summary>
        public ProactiveInsight ProactiveInsight
        {
            get { return this._proactiveInsight; }
            set { this._proactiveInsight = value; }
        }

        // Check to see if ProactiveInsight property is set
        internal bool IsSetProactiveInsight()
        {
            return this._proactiveInsight != null;
        }

        /// <summary>
        /// Gets and sets the property ReactiveInsight. 
        /// <para>
        ///  An <code>ReactiveInsight</code> object that represents the requested insight. 
        /// </para>
        /// </summary>
        public ReactiveInsight ReactiveInsight
        {
            get { return this._reactiveInsight; }
            set { this._reactiveInsight = value; }
        }

        // Check to see if ReactiveInsight property is set
        internal bool IsSetReactiveInsight()
        {
            return this._reactiveInsight != null;
        }

    }
}