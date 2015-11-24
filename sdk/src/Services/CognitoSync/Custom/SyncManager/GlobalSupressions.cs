/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
 
using System.Diagnostics.CodeAnalysis;


[module: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope="member", Target="Amazon.CognitoSync.SyncManager.CognitoSyncManager.#RefreshDatasetMetadataAsync(System.Threading.CancellationToken)")]
[module: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope="member", Target="Amazon.CognitoSync.SyncManager.IRemoteDataStorage.#GetDatasetMetadataAsync(System.Threading.CancellationToken)")]
[module: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope="member", Target="Amazon.CognitoSync.SyncManager.IRemoteDataStorage.#PutRecordsAsync(System.String,System.Collections.Generic.List`1<Amazon.CognitoSync.SyncManager.Record>,System.String,System.Threading.CancellationToken)")]



[module: SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member", Target = "Amazon.CognitoSync.SyncManager.Dataset.#OnDatasetMerged")]
[module: SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member", Target = "Amazon.CognitoSync.SyncManager.Dataset.#OnDatasetDeleted")]
[module: SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields", Scope = "member", Target = "Amazon.CognitoSync.SyncManager.Dataset.#OnSyncConflict")]



[module: SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Amazon.CognitoSync.SyncManager.Dataset+DatasetDeletedDelegate")]
[module: SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Amazon.CognitoSync.SyncManager.Dataset+DatasetMergedDelegate")]
[module: SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Amazon.CognitoSync.SyncManager.Dataset+SyncConflictDelegate")]


[module: SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Scope = "member", Target = "Amazon.CognitoSync.SyncManager.Dataset.#FireSyncFailureEvent(System.Exception)")]
[module: SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Scope = "member", Target = "Amazon.CognitoSync.SyncManager.Dataset.#FireSyncSuccessEvent(System.Collections.Generic.List`1<Amazon.CognitoSync.SyncManager.Record>)")]