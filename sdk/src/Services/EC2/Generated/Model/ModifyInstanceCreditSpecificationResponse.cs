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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the ModifyInstanceCreditSpecification operation.
    /// </summary>
    public partial class ModifyInstanceCreditSpecificationResponse : AmazonWebServiceResponse
    {
        private List<SuccessfulInstanceCreditSpecificationItem> _successfulInstanceCreditSpecifications = new List<SuccessfulInstanceCreditSpecificationItem>();
        private List<UnsuccessfulInstanceCreditSpecificationItem> _unsuccessfulInstanceCreditSpecifications = new List<UnsuccessfulInstanceCreditSpecificationItem>();

        /// <summary>
        /// Gets and sets the property SuccessfulInstanceCreditSpecifications. 
        /// <para>
        /// Information about the instances whose credit option for CPU usage was successfully
        /// modified.
        /// </para>
        /// </summary>
        public List<SuccessfulInstanceCreditSpecificationItem> SuccessfulInstanceCreditSpecifications
        {
            get { return this._successfulInstanceCreditSpecifications; }
            set { this._successfulInstanceCreditSpecifications = value; }
        }

        // Check to see if SuccessfulInstanceCreditSpecifications property is set
        internal bool IsSetSuccessfulInstanceCreditSpecifications()
        {
            return this._successfulInstanceCreditSpecifications != null && this._successfulInstanceCreditSpecifications.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UnsuccessfulInstanceCreditSpecifications. 
        /// <para>
        /// Information about the instances whose credit option for CPU usage was not modified.
        /// </para>
        /// </summary>
        public List<UnsuccessfulInstanceCreditSpecificationItem> UnsuccessfulInstanceCreditSpecifications
        {
            get { return this._unsuccessfulInstanceCreditSpecifications; }
            set { this._unsuccessfulInstanceCreditSpecifications = value; }
        }

        // Check to see if UnsuccessfulInstanceCreditSpecifications property is set
        internal bool IsSetUnsuccessfulInstanceCreditSpecifications()
        {
            return this._unsuccessfulInstanceCreditSpecifications != null && this._unsuccessfulInstanceCreditSpecifications.Count > 0; 
        }

    }
}