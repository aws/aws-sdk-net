/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// <para>Returns the objects or data listed below if successful. Otherwise, returns an error.</para>
    /// </summary>
    public class ResolveCaseResult
    {
        
        private string initialCaseStatus;
        private string finalCaseStatus;

        /// <summary>
        /// Status of the case when the <a href="API_ResolveCase.html" title="ResolveCase">ResolveCase</a> request was sent.
        ///  
        /// </summary>
        public string InitialCaseStatus
        {
            get { return this.initialCaseStatus; }
            set { this.initialCaseStatus = value; }
        }

        /// <summary>
        /// Sets the InitialCaseStatus property
        /// </summary>
        /// <param name="initialCaseStatus">The value to set for the InitialCaseStatus property </param>
        /// <returns>this instance</returns>
        public ResolveCaseResult WithInitialCaseStatus(string initialCaseStatus)
        {
            this.initialCaseStatus = initialCaseStatus;
            return this;
        }
            

        // Check to see if InitialCaseStatus property is set
        internal bool IsSetInitialCaseStatus()
        {
            return this.initialCaseStatus != null;
        }

        /// <summary>
        /// Status of the case after the <a href="API_ResolveCase.html" title="ResolveCase">ResolveCase</a> request was processed.
        ///  
        /// </summary>
        public string FinalCaseStatus
        {
            get { return this.finalCaseStatus; }
            set { this.finalCaseStatus = value; }
        }

        /// <summary>
        /// Sets the FinalCaseStatus property
        /// </summary>
        /// <param name="finalCaseStatus">The value to set for the FinalCaseStatus property </param>
        /// <returns>this instance</returns>
        public ResolveCaseResult WithFinalCaseStatus(string finalCaseStatus)
        {
            this.finalCaseStatus = finalCaseStatus;
            return this;
        }
            

        // Check to see if FinalCaseStatus property is set
        internal bool IsSetFinalCaseStatus()
        {
            return this.finalCaseStatus != null;
        }
    }
}
