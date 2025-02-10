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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
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
namespace Amazon.MailManager.Model
{
    /// <summary>
    /// The union type representing the allowed types of operands for a boolean condition.
    /// </summary>
    public partial class IngressBooleanToEvaluate
    {
        private IngressAnalysis _analysis;
        private IngressIsInAddressList _isInAddressList;

        /// <summary>
        /// Gets and sets the property Analysis. 
        /// <para>
        /// The structure type for a boolean condition stating the Add On ARN and its returned
        /// value.
        /// </para>
        /// </summary>
        public IngressAnalysis Analysis
        {
            get { return this._analysis; }
            set { this._analysis = value; }
        }

        // Check to see if Analysis property is set
        internal bool IsSetAnalysis()
        {
            return this._analysis != null;
        }

        /// <summary>
        /// Gets and sets the property IsInAddressList. 
        /// <para>
        /// The structure type for a boolean condition that provides the address lists to evaluate
        /// incoming traffic on.
        /// </para>
        /// </summary>
        public IngressIsInAddressList IsInAddressList
        {
            get { return this._isInAddressList; }
            set { this._isInAddressList = value; }
        }

        // Check to see if IsInAddressList property is set
        internal bool IsSetIsInAddressList()
        {
            return this._isInAddressList != null;
        }

    }
}