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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeAccountCustomization operation.
    /// Describes the customizations associated with the provided AWS account and Amazon QuickSight
    /// namespace in an AWS Region. The QuickSight console evaluates which customizations
    /// to apply by running this API operation with the <code>Resolved</code> flag included.
    /// 
    /// 
    ///  
    /// <para>
    /// To determine what customizations display when you run this command, it can help to
    /// visualize the relationship of the entities involved. 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>AWS Account</code> - The AWS account exists at the top of the hierarchy. It
    /// has the potential to use all of the AWS Regions and AWS Services. When you subscribe
    /// to QuickSight, you choose one AWS Region to use as your home Region. That's where
    /// your free SPICE capacity is located. You can use QuickSight in any supported AWS Region.
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>AWS Region</code> - In each AWS Region where you sign in to QuickSight at least
    /// once, QuickSight acts as a separate instance of the same service. If you have a user
    /// directory, it resides in us-east-1, which is the US East (N. Virginia). Generally
    /// speaking, these users have access to QuickSight in any AWS Region, unless they are
    /// constrained to a namespace. 
    /// </para>
    ///  
    /// <para>
    /// To run the command in a different AWS Region, you change your Region settings. If
    /// you're using the AWS CLI, you can use one of the following options:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Use <a href="https://docs.aws.amazon.com/cli/latest/userguide/cli-configure-options.html">command
    /// line options</a>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <a href="https://docs.aws.amazon.com/cli/latest/userguide/cli-configure-profiles.html">named
    /// profiles</a>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Run <code>aws configure</code> to change your default AWS Region. Use Enter to key
    /// the same settings for your keys. For more information, see <a href="https://docs.aws.amazon.com/cli/latest/userguide/cli-chap-configure.html">Configuring
    /// the AWS CLI</a>.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <code>Namespace</code> - A QuickSight namespace is a partition that contains users
    /// and assets (data sources, datasets, dashboards, and so on). To access assets that
    /// are in a specific namespace, users and groups must also be part of the same namespace.
    /// People who share a namespace are completely isolated from users and assets in other
    /// namespaces, even if they are in the same AWS account and AWS Region.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Applied customizations</code> - Within an AWS Region, a set of QuickSight customizations
    /// can apply to an AWS account or to a namespace. Settings that you apply to a namespace
    /// override settings that you apply to an AWS account. All settings are isolated to a
    /// single AWS Region. To apply them in other AWS Regions, run the <code>CreateAccountCustomization</code>
    /// command in each AWS Region where you want to apply the same customizations. 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DescribeAccountCustomizationRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private string _awsNamespace;
        private bool? _resolved;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID for the AWS account that you want to describe QuickSight customizations for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The QuickSight namespace that you want to describe QuickSight customizations for.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property Resolved. 
        /// <para>
        /// The <code>Resolved</code> flag works with the other parameters to determine which
        /// view of QuickSight customizations is returned. You can add this flag to your command
        /// to use the same view that QuickSight uses to identify which customizations to apply
        /// to the console. Omit this flag, or set it to <code>no-resolved</code>, to reveal customizations
        /// that are configured at different levels. 
        /// </para>
        /// </summary>
        public bool Resolved
        {
            get { return this._resolved.GetValueOrDefault(); }
            set { this._resolved = value; }
        }

        // Check to see if Resolved property is set
        internal bool IsSetResolved()
        {
            return this._resolved.HasValue; 
        }

    }
}