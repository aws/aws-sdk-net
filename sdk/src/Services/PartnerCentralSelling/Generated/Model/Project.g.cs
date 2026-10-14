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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// An object that contains the <c>Opportunity</c>'s project details.
    /// </summary>
    public partial class Project
    {
        /// <summary>
        /// Gets and sets the property AdditionalComments. 
        /// <para>
        /// Captures additional comments or information for the <c>Opportunity</c> that weren't
        /// captured in other fields.
        /// </para>
        /// </summary>
        public string AdditionalComments { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalComments property is set.
        /// </summary>
        internal bool IsSetAdditionalComments() => this.AdditionalComments != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ApnPrograms { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ApnPrograms property is set.
        /// </summary>
        internal bool IsSetApnPrograms() => this.ApnPrograms != null && (this.ApnPrograms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AwsPartition. 
        /// <para>
        /// AWS partition where the opportunity will be deployed. Possible values: <c>aws-eusc</c>
        /// for AWS European Sovereign Cloud, <c>null</c> for all other partitions.
        /// </para>
        /// </summary>
        public AwsPartition AwsPartition { get; set; }

        /// <summary>
        /// Checks to see if the AwsPartition property is set.
        /// </summary>
        internal bool IsSetAwsPartition() => this.AwsPartition != null;

        /// <summary>
        /// Gets and sets the property CompetitorName. 
        /// <para>
        /// Name of the <c>Opportunity</c>'s competitor (if any). Use <c>Other</c> to submit a
        /// value not in the picklist.
        /// </para>
        /// </summary>
        public CompetitorName CompetitorName { get; set; }

        /// <summary>
        /// Checks to see if the CompetitorName property is set.
        /// </summary>
        internal bool IsSetCompetitorName() => this.CompetitorName != null;

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
        [AWSProperty(Sensitive = true)]
        public string CustomerBusinessProblem { get; set; }

        /// <summary>
        /// Checks to see if the CustomerBusinessProblem property is set.
        /// </summary>
        internal bool IsSetCustomerBusinessProblem() => this.CustomerBusinessProblem != null;

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
        public string CustomerUseCase { get; set; }

        /// <summary>
        /// Checks to see if the CustomerUseCase property is set.
        /// </summary>
        internal bool IsSetCustomerUseCase() => this.CustomerUseCase != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DeliveryModels { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DeliveryModels property is set.
        /// </summary>
        internal bool IsSetDeliveryModels() => this.DeliveryModels != null && (this.DeliveryModels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExpectedContractDuration. 
        /// <para>
        /// Optional. The expected duration of the contract associated with this opportunity.
        /// Partners use this value alongside expected customer spend to convert Total Contract
        /// Value (TCV) into Monthly Recurring Revenue (MRR).
        /// </para>
        /// </summary>
        public ExpectedContractDuration ExpectedContractDuration { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedContractDuration property is set.
        /// </summary>
        internal bool IsSetExpectedContractDuration() => this.ExpectedContractDuration != null;

        /// <summary>
        /// Gets and sets the property ExpectedCustomerSpend. 
        /// <para>
        /// Represents the estimated amount that the customer is expected to spend on AWS services
        /// related to the opportunity. This helps in evaluating the potential financial value
        /// of the opportunity for AWS.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<ExpectedCustomerSpend> ExpectedCustomerSpend { get; set; } = AWSConfigs.InitializeCollections ? new List<ExpectedCustomerSpend>() : null;

        /// <summary>
        /// Checks to see if the ExpectedCustomerSpend property is set.
        /// </summary>
        internal bool IsSetExpectedCustomerSpend() => this.ExpectedCustomerSpend != null && (this.ExpectedCustomerSpend.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OtherCompetitorNames. 
        /// <para>
        /// Only allowed when <c>CompetitorNames</c> has <c>Other</c> selected.
        /// </para>
        /// </summary>
        public string OtherCompetitorNames { get; set; }

        /// <summary>
        /// Checks to see if the OtherCompetitorNames property is set.
        /// </summary>
        internal bool IsSetOtherCompetitorNames() => this.OtherCompetitorNames != null;

        /// <summary>
        /// Gets and sets the property OtherSolutionDescription. 
        /// <para>
        /// Specifies the offered solution for the customer's business problem when the <c> RelatedEntityIdentifiers.Solutions</c>
        /// field value is <c>Other</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string OtherSolutionDescription { get; set; }

        /// <summary>
        /// Checks to see if the OtherSolutionDescription property is set.
        /// </summary>
        internal bool IsSetOtherSolutionDescription() => this.OtherSolutionDescription != null;

        /// <summary>
        /// Gets and sets the property RelatedOpportunityIdentifier. 
        /// <para>
        /// Specifies the current opportunity's parent opportunity identifier.
        /// </para>
        /// </summary>
        public string RelatedOpportunityIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the RelatedOpportunityIdentifier property is set.
        /// </summary>
        internal bool IsSetRelatedOpportunityIdentifier() => this.RelatedOpportunityIdentifier != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SalesActivities { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SalesActivities property is set.
        /// </summary>
        internal bool IsSetSalesActivities() => this.SalesActivities != null && (this.SalesActivities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// Specifies the <c>Opportunity</c>'s title or name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
