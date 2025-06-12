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
    /// An object that contains the <c>Opportunity</c>'s project details.
    /// </summary>
    public partial class Project
    {
        private string _additionalComments;
        private List<string> _apnPrograms = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private CompetitorName _competitorName;
        private string _customerBusinessProblem;
        private string _customerUseCase;
        private List<string> _deliveryModels = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<ExpectedCustomerSpend> _expectedCustomerSpend = AWSConfigs.InitializeCollections ? new List<ExpectedCustomerSpend>() : null;
        private string _otherCompetitorNames;
        private string _otherSolutionDescription;
        private string _relatedOpportunityIdentifier;
        private List<string> _salesActivities = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _title;

        /// <summary>
        /// Gets and sets the property AdditionalComments. 
        /// <para>
        /// Captures additional comments or information for the <c>Opportunity</c> that weren't
        /// captured in other fields.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string AdditionalComments
        {
            get { return this._additionalComments; }
            set { this._additionalComments = value; }
        }

        // Check to see if AdditionalComments property is set
        internal bool IsSetAdditionalComments()
        {
            return this._additionalComments != null;
        }

        /// <summary>
        /// Gets and sets the property ApnPrograms. 
        /// <para>
        /// Specifies the Amazon Partner Network (APN) program that influenced the <c>Opportunity</c>.
        /// APN programs refer to specific partner programs or initiatives that can impact the
        /// <c>Opportunity</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>APN Immersion Days | APN Solution Space | ATO (Authority to Operate)
        /// | AWS Marketplace Campaign | IS Immersion Day SFID Program | ISV Workload Migration
        /// | Migration Acceleration Program | P3 | Partner Launch Initiative | Partner Opportunity
        /// Acceleration Funded | The Next Smart | VMware Cloud on AWS | Well-Architected | Windows
        /// | Workspaces/AppStream Accelerator Program | WWPS NDPP</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ApnPrograms
        {
            get { return this._apnPrograms; }
            set { this._apnPrograms = value; }
        }

        // Check to see if ApnPrograms property is set
        internal bool IsSetApnPrograms()
        {
            return this._apnPrograms != null && (this._apnPrograms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CompetitorName. 
        /// <para>
        /// Name of the <c>Opportunity</c>'s competitor (if any). Use <c>Other</c> to submit a
        /// value not in the picklist.
        /// </para>
        /// </summary>
        public CompetitorName CompetitorName
        {
            get { return this._competitorName; }
            set { this._competitorName = value; }
        }

        // Check to see if CompetitorName property is set
        internal bool IsSetCompetitorName()
        {
            return this._competitorName != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerBusinessProblem. 
        /// <para>
        /// Describes the problem the end customer has, and how the partner is helping. Utilize
        /// this field to provide a concise narrative that outlines the customer's business challenge
        /// or issue. Elaborate on how the partner's solution or offerings align to resolve the
        /// customer's business problem. Include relevant information about the partner's value
        /// proposition, unique selling points, and expertise to tackle the issue. Offer insights
        /// on how the proposed solution meets the customer's needs and provides value. Use concise
        /// language and precise descriptions to convey the context and significance of the <c>Opportunity</c>.
        /// The content in this field helps Amazon Web Services understand the nature of the <c>Opportunity</c>
        /// and the strategic fit of the partner's solution.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=20, Max=2000)]
        public string CustomerBusinessProblem
        {
            get { return this._customerBusinessProblem; }
            set { this._customerBusinessProblem = value; }
        }

        // Check to see if CustomerBusinessProblem property is set
        internal bool IsSetCustomerBusinessProblem()
        {
            return this._customerBusinessProblem != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerUseCase. 
        /// <para>
        /// Specifies the proposed solution focus or type of workload for the Opportunity. This
        /// field captures the primary use case or objective of the proposed solution, and provides
        /// context and clarity to the addressed workload.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>AI Machine Learning and Analytics | Archiving | Big Data: Data Warehouse/Data
        /// Integration/ETL/Data Lake/BI | Blockchain | Business Applications: Mainframe Modernization
        /// | Business Applications &amp; Contact Center | Business Applications &amp; SAP Production
        /// | Centralized Operations Management | Cloud Management Tools | Cloud Management Tools
        /// &amp; DevOps with Continuous Integration &amp; Continuous Delivery (CICD) | Configuration,
        /// Compliance &amp; Auditing | Connected Services | Containers &amp; Serverless | Content
        /// Delivery &amp; Edge Services | Database | Edge Computing/End User Computing | Energy
        /// | Enterprise Governance &amp; Controls | Enterprise Resource Planning | Financial
        /// Services | Healthcare and Life Sciences | High Performance Computing | Hybrid Application
        /// Platform | Industrial Software | IOT | Manufacturing, Supply Chain and Operations
        /// | Media &amp; High performance computing (HPC) | Migration/Database Migration | Monitoring,
        /// logging and performance | Monitoring &amp; Observability | Networking | Outpost |
        /// SAP | Security &amp; Compliance | Storage &amp; Backup | Training | VMC | VMWare |
        /// Web development &amp; DevOps</c> 
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
        /// Specifies the deployment or consumption model for your solution or service in the
        /// <c>Opportunity</c>'s context. You can select multiple options.
        /// </para>
        ///  
        /// <para>
        /// Options' descriptions from the <c>Delivery Model</c> field are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// SaaS or PaaS: Your Amazon Web Services based solution deployed as SaaS or PaaS in
        /// your Amazon Web Services environment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// BYOL or AMI: Your Amazon Web Services based solution deployed as BYOL or AMI in the
        /// end customer's Amazon Web Services environment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Managed Services: The end customer's Amazon Web Services business management (For
        /// example: Consulting, design, implementation, billing support, cost optimization, technical
        /// support).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Professional Services: Offerings to help enterprise end customers achieve specific
        /// business outcomes for enterprise cloud adoption (For example: Advisory or transformation
        /// planning).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Resell: Amazon Web Services accounts and billing management for your customers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Other: Delivery model not described above.
        /// </para>
        ///  </li> </ul>
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
        /// Represents the estimated amount that the customer is expected to spend on AWS services
        /// related to the opportunity. This helps in evaluating the potential financial value
        /// of the opportunity for AWS.
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
        /// Gets and sets the property OtherCompetitorNames. 
        /// <para>
        /// Only allowed when <c>CompetitorNames</c> has <c>Other</c> selected.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string OtherCompetitorNames
        {
            get { return this._otherCompetitorNames; }
            set { this._otherCompetitorNames = value; }
        }

        // Check to see if OtherCompetitorNames property is set
        internal bool IsSetOtherCompetitorNames()
        {
            return this._otherCompetitorNames != null;
        }

        /// <summary>
        /// Gets and sets the property OtherSolutionDescription. 
        /// <para>
        /// Specifies the offered solution for the customer's business problem when the <c> RelatedEntityIdentifiers.Solutions</c>
        /// field value is <c>Other</c>.
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
        /// Gets and sets the property RelatedOpportunityIdentifier. 
        /// <para>
        /// Specifies the current opportunity's parent opportunity identifier.
        /// </para>
        /// </summary>
        public string RelatedOpportunityIdentifier
        {
            get { return this._relatedOpportunityIdentifier; }
            set { this._relatedOpportunityIdentifier = value; }
        }

        // Check to see if RelatedOpportunityIdentifier property is set
        internal bool IsSetRelatedOpportunityIdentifier()
        {
            return this._relatedOpportunityIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SalesActivities. 
        /// <para>
        /// Specifies the <c>Opportunity</c>'s sales activities conducted with the end customer.
        /// These activities help drive Amazon Web Services assignment priority.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Initialized discussions with customer: Initial conversations with the customer to
        /// understand their needs and introduce your solution.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Customer has shown interest in solution: After initial discussions, the customer is
        /// interested in your solution.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Conducted POC/demo: You conducted a proof of concept (POC) or demonstration of the
        /// solution for the customer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In evaluation/planning stage: The customer is evaluating the solution and planning
        /// potential implementation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Agreed on solution to Business Problem: Both parties agree on how the solution addresses
        /// the customer's business problem.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Completed Action Plan: A detailed action plan is complete and outlines the steps for
        /// implementation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Finalized Deployment Need: Both parties agree with and finalized the deployment needs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SOW Signed: Both parties signed a statement of work (SOW), and formalize the agreement
        /// and detail the project scope and deliverables.
        /// </para>
        ///  </li> </ul>
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

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// Specifies the <c>Opportunity</c>'s title or name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=255)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}