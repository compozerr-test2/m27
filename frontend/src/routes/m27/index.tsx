import React from "react"
import { createFileRoute } from '@tanstack/react-router'
import M27Component from '../../m27-component'

export const Route = createFileRoute('/m27/')({
  component: RouteComponent,
})

function RouteComponent() {
  return (
    <div>
      <M27Component name="World!" />
    </div>
  )
}
