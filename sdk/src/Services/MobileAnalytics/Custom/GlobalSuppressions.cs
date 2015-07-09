/*
 * Copyright 2015-2015 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using System.Diagnostics.CodeAnalysis;


// Identifier should not match keywords
[module: SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", Scope="type", Target="Amazon.MobileAnalytics.Model.Event", MessageId="Event")]


// supress warning for implementing ISerializable interface
[module: SuppressMessage("Microsoft.Usage", "CA2237:MarkISerializableTypesWithSerializable", Scope="type", Target="Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.EventStoreException")]

// supress warning for implementing IDisposable interface
[module: SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable", Scope = "type", Target = "Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.DeliveryClient")]

// Keep MobileAnalyticsManager namespace
[module: SuppressMessage("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces", Scope = "type", Target = "Amazon.MobileAnalytics.MobileAnalyticsManager.MobileAnalyticsManager")]


[module: SuppressMessage("Microsoft.Security", "CA2141:TransparentMethodsMustNotSatisfyLinkDemandsFxCopRule", Scope = "member", Target = "Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.SQLiteEventStore.#GetEvents(System.String,System.Int32)")]
[module: SuppressMessage("Microsoft.Security", "CA2141:TransparentMethodsMustNotSatisfyLinkDemandsFxCopRule", Scope = "member", Target = "Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.SQLiteEventStore.#DeleteEvent(System.Collections.Generic.List`1<System.String>)")]
[module: SuppressMessage("Microsoft.Security", "CA2141:TransparentMethodsMustNotSatisfyLinkDemandsFxCopRule", Scope = "member", Target = "Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.SQLiteEventStore.#PutEvent(System.String,System.String)")]
[module: SuppressMessage("Microsoft.Security", "CA2141:TransparentMethodsMustNotSatisfyLinkDemandsFxCopRule", Scope = "member", Target = "Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.SQLiteEventStore.#NumberOfEvents(System.String)")]
[module: SuppressMessage("Microsoft.Security", "CA2141:TransparentMethodsMustNotSatisfyLinkDemandsFxCopRule", Scope = "member", Target = "Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.SQLiteEventStore.#SetUpDatabase()")]


// supress warnings for catching general exception
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.MobileAnalytics.MobileAnalyticsManager.MobileAnalyticsManager.#ResumeSession()")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.MobileAnalytics.MobileAnalyticsManager.MobileAnalyticsManager.#PauseSession()")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.Session.#RetrieveSessionStorage()")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.DeliveryClient.#EnqueueEventsForDeliveryAsync(Amazon.MobileAnalytics.Model.Event)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.SQLiteEventStore.#GetEvents(System.String,System.Int32)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.SQLiteEventStore.#DeleteEvent(System.Collections.Generic.List`1<System.String>)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.SQLiteEventStore.#PutEvent(System.String,System.String)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.SQLiteEventStore.#NumberOfEvents(System.String)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.SQLiteEventStore.#SetUpDatabase()")]
