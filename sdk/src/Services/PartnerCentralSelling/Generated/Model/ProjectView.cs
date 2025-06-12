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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Provides the project view of an opportunity resource shared through a snapshot.
    /// </summary>
    public partial class ProjectView
    {
        private string _customerUseCase;
        private List<string> _deliveryModels = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<ExpectedCustomerSpend> _expectedCustomerSpend = AWSConfigs.InitializeCollections ? new List<ExpectedCustomerSpend>() : null;
        private string _otherSolutionDescription;
        private List<string> _salesActivities = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property CustomerUseCase. 
        /// <para>
        ///  Specifies the proposed solution focus or type of workload for the project. 
        /// </para>
        /// </summary>
        public string CustomerUseCase
        {
            get { return this._customerUseCase; }
            set { this._customerUseCase = value; }
        }

        // Check to see if CustomerUseCase property is set
        internal bool IsSetCustomerUseCase()
        {
            return this._customerUseCase != null;
        }

        /// <summary>
        /// Gets and sets the property DeliveryModels. 
        /// <para>
        ///  Describes the deployment or consumption model for the partner solution or offering.
        /// This field indicates how the project's solution will be delivered or implemented for
        /// the customer. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DeliveryModels
        {
            get { return this._deliveryModels; }
            set { this._deliveryModels = value; }
        }

        // Check to see if DeliveryModels property is set
        internal bool IsSetDeliveryModels()
        {
            return this._deliveryModels != null && (this._deliveryModels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExpectedCustomerSpend. 
        /// <para>
        ///  Provides information about the anticipated customer spend related to this project.
        /// This may include details such as amount, frequency, and currency of expected expenditure.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<ExpectedCustomerSpend> ExpectedCustomerSpend
        {
            get { return this._expectedCustomerSpend; }
            set { this._expectedCustomerSpend = value; }
        }

        // Check to see if ExpectedCustomerSpend property is set
        internal bool IsSetExpectedCustomerSpend()
        {
            return this._expectedCustomerSpend != null && (this._expectedCustomerSpend.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OtherSolutionDescription. 
        /// <para>
        ///  Offers a description of other solutions if the standard solutions do not adequately
        /// cover the project's scope. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=255)]
        public string OtherSolutionDescription
        {
            get { return this._otherSolutionDescription; }
            set { this._otherSolutionDescription = value; }
        }

        // Check to see if OtherSolutionDescription property is set
        internal bool IsSetOtherSolutionDescription()
        {
            return this._otherSolutionDescription != null;
        }

        /// <summary>
        /// Gets and sets the property SalesActivities. 
        /// <para>
        ///  Lists the pre-sales activities that have occurred with the end-customer related to
        /// the opportunity. This field is conditionally mandatory when the project is qualified
        /// for Co-Sell and helps drive assignment priority on the AWS side. It provides insight
        /// into the engagement level with the customer. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SalesActivities
        {
            get { return this._salesActivities; }
            set { this._salesActivities = value; }
        }

        // Check to see if SalesActivities property is set
        internal bool IsSetSalesActivities()
        {
            return this._salesActivities != null && (this._salesActivities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}