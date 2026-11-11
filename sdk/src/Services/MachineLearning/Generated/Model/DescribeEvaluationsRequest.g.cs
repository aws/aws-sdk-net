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

namespace Amazon.MachineLearning.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeEvaluations operation. Returns a list
    /// of <c>DescribeEvaluations</c> that match the search criteria in the request.
    /// </summary>
    public partial class DescribeEvaluationsRequest : AmazonMachineLearningRequest
    {
        /// <summary>
        /// Gets and sets the property EQ. 
        /// <para>
        /// The equal to operator. The <c>Evaluation</c> results will have <c>FilterVariable</c>
        /// values that exactly match the value specified with <c>EQ</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string EQ { get; set; }

        /// <summary>
        /// Checks to see if the EQ property is set.
        /// </summary>
        internal bool IsSetEQ() => this.EQ != null;

        /// <summary>
        /// Gets and sets the property FilterVariable. 
        /// <para>
        /// Use one of the following variable to filter a list of <c>Evaluation</c> objects:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CreatedAt</c> - Sets the search criteria to the <c>Evaluation</c> creation date.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Status</c> - Sets the search criteria to the <c>Evaluation</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Name</c> - Sets the search criteria to the contents of <c>Evaluation</c> <b> </b>
        /// <c>Name</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IAMUser</c> - Sets the search criteria to the user account that invoked an <c>Evaluation</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MLModelId</c> - Sets the search criteria to the <c>MLModel</c> that was evaluated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DataSourceId</c> - Sets the search criteria to the <c>DataSource</c> used in <c>Evaluation</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DataUri</c> - Sets the search criteria to the data file(s) used in <c>Evaluation</c>.
        /// The URL can identify either a file or an Amazon Simple Storage Solution (Amazon S3)
        /// bucket or directory.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EvaluationFilterVariable FilterVariable { get; set; }

        /// <summary>
        /// Checks to see if the FilterVariable property is set.
        /// </summary>
        internal bool IsSetFilterVariable() => this.FilterVariable != null;

        /// <summary>
        /// Gets and sets the property GE. 
        /// <para>
        /// The greater than or equal to operator. The <c>Evaluation</c> results will have <c>FilterVariable</c>
        /// values that are greater than or equal to the value specified with <c>GE</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string GE { get; set; }

        /// <summary>
        /// Checks to see if the GE property is set.
        /// </summary>
        internal bool IsSetGE() => this.GE != null;

        /// <summary>
        /// Gets and sets the property GT. 
        /// <para>
        /// The greater than operator. The <c>Evaluation</c> results will have <c>FilterVariable</c>
        /// values that are greater than the value specified with <c>GT</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string GT { get; set; }

        /// <summary>
        /// Checks to see if the GT property is set.
        /// </summary>
        internal bool IsSetGT() => this.GT != null;

        /// <summary>
        /// Gets and sets the property LE. 
        /// <para>
        /// The less than or equal to operator. The <c>Evaluation</c> results will have <c>FilterVariable</c>
        /// values that are less than or equal to the value specified with <c>LE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string LE { get; set; }

        /// <summary>
        /// Checks to see if the LE property is set.
        /// </summary>
        internal bool IsSetLE() => this.LE != null;

        /// <summary>
        /// Gets and sets the property LT. 
        /// <para>
        /// The less than operator. The <c>Evaluation</c> results will have <c>FilterVariable</c>
        /// values that are less than the value specified with <c>LT</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string LT { get; set; }

        /// <summary>
        /// Checks to see if the LT property is set.
        /// </summary>
        internal bool IsSetLT() => this.LT != null;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        ///  The maximum number of <c>Evaluation</c> to include in the result.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property NE. 
        /// <para>
        /// The not equal to operator. The <c>Evaluation</c> results will have <c>FilterVariable</c>
        /// values not equal to the value specified with <c>NE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string NE { get; set; }

        /// <summary>
        /// Checks to see if the NE property is set.
        /// </summary>
        internal bool IsSetNE() => this.NE != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The ID of the page in the paginated results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// A string that is found at the beginning of a variable, such as <c>Name</c> or <c>Id</c>.
        /// </para>
        ///  
        /// <para>
        /// For example, an <c>Evaluation</c> could have the <c>Name</c> <c>2014-09-09-HolidayGiftMailer</c>.
        /// To search for this <c>Evaluation</c>, select <c>Name</c> for the <c>FilterVariable</c>
        /// and any of the following strings for the <c>Prefix</c>: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// 2014-09
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 2014-09-09
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 2014-09-09-Holiday
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Prefix { get; set; }

        /// <summary>
        /// Checks to see if the Prefix property is set.
        /// </summary>
        internal bool IsSetPrefix() => this.Prefix != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// A two-value parameter that determines the sequence of the resulting list of <c>Evaluation</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>asc</c> - Arranges the list in ascending order (A-Z, 0-9).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>dsc</c> - Arranges the list in descending order (Z-A, 9-0).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Results are sorted by <c>FilterVariable</c>.
        /// </para>
        /// </summary>
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;
    }
}
