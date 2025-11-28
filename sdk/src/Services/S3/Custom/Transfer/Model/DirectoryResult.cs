/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */

namespace Amazon.S3.Transfer.Model
{
    /// <summary>
    /// Overall outcome of a directory operation.
    /// </summary>
    public enum DirectoryResult
    {
        /// <summary>
        /// All objects processed successfully.
        /// </summary>
        Success,
        /// <summary>
        /// Some objects succeeded and some failed.
        /// </summary>
        PartialSuccess,
        /// <summary>
        /// All attempted objects failed.
        /// </summary>
        Failure
    }
}